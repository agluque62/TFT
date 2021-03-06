﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Microsoft.Deployment.WindowsInstaller;
using HMI.CD40.Module.BusinessEntities;
using System.Threading;
using NAudio.CoreAudioApi;

namespace Ulises5000_AT_HMI_CustomActions
{
    public class CustomActions
    {
        [CustomAction]
        public static ActionResult Ed137RecVar(Session session)
        {
            session.Log("Begin Ed137RecVar");

            int varInt = int.Parse(session["ED137REC"]);

            session["ED137REC"] = (varInt & 0x01).ToString();
            session["RECDUAL"] = (varInt & 0x02) != 0 ? "1" : "0";

            return ActionResult.Success;
        }
        [CustomAction]
        public static ActionResult GenerateSpreadConf(Session session)
        {
            System.IO.StreamWriter conf;
            try
            {
                System.IO.Directory.CreateDirectory(session["U5ki.MCast.INSTALLFOLDER"]);
                int nItems = int.Parse(session["SPREAD_NUMBER"]);
                byte[] ipbase = IPAddress.Parse(session["SPREAD_IPBASE"]).GetAddressBytes();

                /** */
                View lView = session.Database.OpenView("DELETE FROM ComboBox WHERE ComboBox.Property='PICT'");
                lView.Execute();
                lView = session.Database.OpenView("SELECT * FROM ComboBox");
                lView.Execute();

                using (conf = new System.IO.StreamWriter(session["U5ki.MCast.INSTALLFOLDER"] + "spread.conf", false))
                {
                    conf.WriteLine(String.Format("Spread_Segment  239.255.10.50:4803 {{"));

                    for (int item = 0; item < nItems; item++)
                    {
                        IPAddress current = new IPAddress(ipbase);
                        conf.WriteLine(String.Format("\t PICT{0:00} {1} {{", item + 1, current.ToString()));

                        conf.WriteLine(String.Format("\t\tD {0}", current.ToString()));
                        conf.WriteLine(String.Format("\t\tC {0}", current.ToString()));
                        conf.WriteLine(String.Format("\t\tC 127.0.0.1"));
                        conf.WriteLine(String.Format("\t }}"));

                        /** */
                        Record lRecord = session.Database.CreateRecord(4);
                        lRecord.SetString(1, "PICT");
                        lRecord.SetInteger(2, item);
                        lRecord.SetString(3, String.Format("PICT{0:00}", item + 1));
                        lRecord.SetString(4, String.Format("PICT{0:00}, {1}", item + 1, current.ToString()));
                        lView.Modify(ViewModifyMode.InsertTemporary, lRecord);

                        ipbase[3]++;
                    }

                    conf.WriteLine(String.Format("}}"));

                    conf.WriteLine("TokenTimeout = 5000");
                    conf.WriteLine("HurryTimeout = 1500");
                    conf.WriteLine("AliveTimeout = 250");
                    conf.WriteLine("JoinTimeout = 250");
                    conf.WriteLine("RepTimeout = 1250");
                    conf.WriteLine("SegTimeout = 500");
                    conf.WriteLine("GatherTimeout = 2500");
                    conf.WriteLine("FormTimeout = 2500");
                    /** 20170903. AGL. Se cambia este parámetro para evitar transitorios en conmutación de NBX... */
                    conf.WriteLine(/*"LookupTimeout = 45000"*/"LookupTimeout = 15000");

                    conf.WriteLine("DebugFlags = { PRINT EXIT }");
                    conf.WriteLine("EventPriority =  INFO");
                    conf.WriteLine("#EventLogFile = testlog.out");
                    conf.WriteLine("EventTimeStamp = \"%Y-%m-%d %H:%M:%S:\"");
                    conf.WriteLine("#EventPreciseTimeStamp");
                    conf.WriteLine("#DebugInitialSequence");
                    conf.WriteLine("DangerousMonitor = true");
                    conf.WriteLine("#SocketPortReuse = AUTO");
                    conf.WriteLine("#MaxSessionMessages = 1000");
                    conf.WriteLine("RuntimeDir = /var/run/spread");
                    conf.WriteLine("DaemonUser = p");
                    conf.WriteLine("DaemonGroup = users");
                    conf.WriteLine("#RequiredAuthMethods = \"   \"");
                    conf.WriteLine("#AllowedAuthMethods = \"NULL\"");

                }
            }
            catch (Exception x)
            {
                session.Log("ERROR in custom action GenerateSpreadConf {0}", x.ToString());
                System.Windows.Forms.MessageBox.Show(String.Format("ERROR in custom action GenerateSpreadConf {0}", x.ToString()));
                return ActionResult.Failure;
            }

            return ActionResult.Success;
        }

        [CustomAction]
        public static ActionResult CustomActionPict2Ip(Session session)
        {
            session.Log("Begin CustomActionPict2Ip");
            try
            {
                int nItems = int.Parse(session["SPREAD_NUMBER"]);
                byte[] ipbase = IPAddress.Parse(session["SPREAD_IPBASE"]).GetAddressBytes();
                string pict = session["PICT"];

                for (int item = 0; item < nItems; item++)
                {
                    if (pict == String.Format("PICT{0:00}", item + 1))
                    {
                        session["DIRIP"] = (new IPAddress(ipbase)).ToString();
                        return ActionResult.Success;
                    }
                    ipbase[3]++;
                }

            }
            catch (Exception x)
            {
                session.Log("ERROR in custom action CustomActionPict2Ip {0}", x.ToString());
                System.Windows.Forms.MessageBox.Show(String.Format("ERROR in custom action CustomActionPict2Ip {0}", x.ToString()));
                return ActionResult.Failure;
            }
            System.Windows.Forms.MessageBox.Show("ERROR en CustomAction CustomActionPict2Ip: No se ha encontrado una IP");
            return ActionResult.Failure;
        }

        [CustomAction]
        public static ActionResult LoadAsioChannels(Session session)
        {
            session.Log("Begin Custiom Action LoadAsioChannels");
            try
            {
                Thread thread = new Thread(AsioChannels.Init);
                thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
                thread.Start();
                thread.Join(); //Wait for the thread to end
                //AsioChannels.Init();
                session.Log("Custiom Action LoadAsioChannels num out channels {0}", AsioChannels.OutChannels.Count);
                /** */
                View lView = session.Database.OpenView("DELETE FROM ComboBox WHERE ComboBox.Property='RADIOSPEAKERDEV'");
                lView.Execute();
                lView = session.Database.OpenView("SELECT * FROM ComboBox");
                lView.Execute();
                string speakers = session["RADIOSPEAKERDEV"];
                int i = 0;
                foreach (String name in AsioChannels.OutChannels)
                {
                    /** */
                    Record lRecord = session.Database.CreateRecord(3);
                    lRecord.SetString(1, "RADIOSPEAKERDEV");
                    lRecord.SetInteger(2, i++);
                    lRecord.SetString(3, name);

                    lView.Modify(ViewModifyMode.InsertTemporary, lRecord);

                    session.Log("Custiom Action LoadAsioChannels {0}", name);
                }
                session["SAMPLERATE"] = AsioChannels.SampleRate.ToString();
            }
            catch (Exception x)
            {
                session.Log("ERROR in custom action LoadAsioChannels {0}", x.ToString());
                System.Windows.Forms.MessageBox.Show(String.Format("ERROR in custom action LoadAsioChannels {0}", x.ToString()));
                return ActionResult.Failure;
            }
            return ActionResult.Success;
        }
        [CustomAction]
        public static ActionResult SetSampleRate(Session session)
        {
            session.Log("Begin Custiom Action SetSampleRate");
            try
            {
                string radioSepakerDevName = session["RADIOSPEAKERDEV"];
                MMDeviceCollection DevCol = new MMDeviceEnumerator().EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
                foreach (MMDevice dev in DevCol)
                {
                    if (dev.DeviceFriendlyName.Equals(radioSepakerDevName))
                    {
                        session["SAMPLERATE"] = dev.AudioClient.MixFormat.SampleRate.ToString();
                        return ActionResult.Success;
                    }
                }

            }
            catch (Exception x)
            {
                session.Log("ERROR in custom action SetSampleRate {0}", x.ToString());
                System.Windows.Forms.MessageBox.Show(String.Format("ERROR in custom action SetSampleRate {0}", x.ToString()));
                return ActionResult.Failure;
            }
            return ActionResult.Success;
        }
    }
    }
