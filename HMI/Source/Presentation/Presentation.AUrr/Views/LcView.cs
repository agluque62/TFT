//----------------------------------------------------------------------------------------
// patterns & practices - Smart Client Software Factory - Guidance Package
//
// This file was generated by the "Add View" recipe.
//
// This class is the concrete implementation of a View in the Model-View-Presenter 
// pattern. Communication between the Presenter and this class is acheived through 
// an interface to facilitate separation and testability.
// Note that the Presenter generated by the same recipe, will automatically be created
// by CAB through [CreateNew] and bidirectional references will be added.
//
// For more information see:
// ms-help://MS.VSCC.v80/MS.VSIPCC.v80/ms.practices.scsf.2007may/SCSF/html/02-09-010-ModelViewPresenter_MVP.htm
//
// Latest version of this Guidance Package: http://go.microsoft.com/fwlink/?LinkId=62182
//----------------------------------------------------------------------------------------

using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.ObjectBuilder;
using Microsoft.Practices.CompositeUI.EventBroker;
using HMI.Infrastructure.Interface;
using HMI.Model.Module.UI;
using HMI.Model.Module.Services;
using HMI.Model.Module.Messages;
using HMI.Model.Module.BusinessEntities;
using HMI.Presentation.AUrr.Constants;
using HMI.Presentation.AUrr.Properties;
using Utilities;
using NLog;

namespace HMI.Presentation.AUrr.Views
{
    [SmartPart]
    public partial class LcView : UserControl
    {
        private static Logger _Logger = LogManager.GetCurrentClassLogger();

        private IModelCmdManagerService _CmdManager = null;
        private StateManagerService _StateManager = null;
        private int _NumPositionsByPage;
        private List<LcButton> _LcButtons = new List<LcButton>();
        private Dictionary<LcButton, Color> _SlowBlinkList;
        private bool _SlowBlinkOn = true;
        private bool _Pulsed = false;

        public LcView([ServiceDependency] IModelCmdManagerService cmdManager, [ServiceDependency] StateManagerService stateManager)
        {
            InitializeComponent();

            _CmdManager = cmdManager;
            _StateManager = stateManager;

            _LcButtonsTLP.RowCount = Settings.Default.LcRows;
            _LcButtonsTLP.RowStyles.Clear();

            for (int i = 0; i < _LcButtonsTLP.RowCount; i++)
            {
                RowStyle st = new RowStyle(SizeType.Percent, 100);
                //_LcButtonsTLP.RowStyles.Add(st);
            }

            _LcButtonsTLP.ColumnCount = Settings.Default.LcColumns;
            _LcButtonsTLP.ColumnStyles.Clear();

            for (int i = 0; i < _LcButtonsTLP.ColumnCount; i++)
            {
                ColumnStyle st = new ColumnStyle(SizeType.Percent, 100);
                //_LcButtonsTLP.ColumnStyles.Add(st);
            }

            _NumPositionsByPage = _LcButtonsTLP.RowCount * _LcButtonsTLP.ColumnCount;
            _SlowBlinkList = new Dictionary<LcButton, Color>();

            for (int row = _LcButtonsTLP.RowCount - 1, pos = 0; row >= 0; row--)
            {
                for (int column = 0; column < _LcButtonsTLP.ColumnCount; column++, pos++)
                {
                    LcButton bt = new LcButton();
                    //_LcButtonsTLP.Controls.Add(bt, column, row);
                    //_LcButtons.Add(bt);

                    bt.Dock = DockStyle.Fill;
                    bt.Name = "_LcButton" + pos;
                    bt.Visible = false;
                    bt.Id = pos;

                    bt.MouseDown += LcButton_MouseDown;
                    bt.MouseUp += LcButton_MouseUp;
                }
            }
        }

        [EventSubscription(EventTopicNames.TftEnabledChanged, ThreadOption.Publisher)]
        [EventSubscription(EventTopicNames.EngineStateChanged, ThreadOption.Publisher)]
        public void OnTftEngineChanged(object sender, EventArgs e)
        {
            foreach (LcButton bt in _LcButtons)
            {
                bt.Enabled = LcDstEnabled(_StateManager.Lc[bt.Id]);
            }
        }

        /*[EventSubscription(EventTopicNames.LcChanged, ThreadOption.Publisher)]
        public void OnLcChanged(object sender, RangeMsg e)
        {
            Debug.Assert(e.Count > 0);

            for (int i = e.From, to = e.From + e.Count; i < to; i++)
            {
                LcDst dst = _StateManager.Lc[i];
                int headerOfGroup = dst.Group != 0 ? _StateManager.Lc.HeaderLc(dst.Group) : i;  //17_01_13 (-1)

                if (headerOfGroup < _NumPositionsByPage)
                {
                    LcButton bt = _LcButtons[headerOfGroup];
                    LcDst activeDst = dst.Group != 0 ? _StateManager.Lc.ActiveLc(dst.Group, bt.Id) : dst;   //17_01_13 (-1)

                    if ((bt.Id != activeDst.Id) || (bt.Id == i))
                    {
                        Reset(bt, activeDst);
                    }
                }
            }
        }
        */
        private bool LcDstEnabled(LcDst dst)
        {
            return _StateManager.Tft.Enabled && _StateManager.Engine.Operative && !dst.Unavailable;
        }

        private void Reset(LcButton bt, LcDst dst)
        {
            bt.Id = dst.Id;

            if (_SlowBlinkList.Remove(bt) && (_SlowBlinkList.Count == 0))
            {
                _SlowBlinkTimer.Enabled = false;
                _SlowBlinkOn = true;
            }

            if (dst.IsConfigurated)
            {
                Color rx = VisualStyle.ButtonColor;
                Color tx = VisualStyle.ButtonColor;

                if (!dst.Unavailable)
                {
                    switch (dst.Rx)
                    {
                        case LcRxState.Idle:
                            break;
                        case LcRxState.Rx:
                        case LcRxState.RxNotif:
                            rx = VisualStyle.Colors.Green;
                            break;
                        case LcRxState.Mem:
                            rx = VisualStyle.Colors.Orange;
                            break;
                    }

                    switch (dst.Tx)
                    {
                        case LcTxState.Idle:
                        case LcTxState.Out:
                            break;
                        case LcTxState.Tx:
                            tx = VisualStyle.Colors.Green;
                            break;
                        case LcTxState.Congestion:
                            tx = _SlowBlinkOn ? VisualStyle.Colors.Red : VisualStyle.ButtonColor;
                            _SlowBlinkList[bt] = VisualStyle.Colors.Red;
                            _SlowBlinkTimer.Enabled = true;
                            break;
                        case LcTxState.Busy:
                            tx = VisualStyle.Colors.Red;
                            break;
                    }
                }

                bt.Reset(dst.Dst, dst.Unavailable, rx, tx);
                bt.Enabled = LcDstEnabled(dst);
            }

            bt.Visible = dst.IsConfigurated;
        }

        private void LcButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (_Pulsed)
                return;
            _Pulsed = true;

            int id = ((LcButton)sender).Id;

            try
            {
                _CmdManager.LcSet(id, true);
            }
            catch (Exception ex)
            {
                int pos = _LcButtons.IndexOf((LcButton)sender);
                string msg = string.Format("ERROR pulsando LC [Pos={0}] [Id={1}]", pos, id);
                _Logger.Error(msg, ex);
            }
        }

        private void LcButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (!_Pulsed)
                return;

            int id = ((LcButton)sender).Id;

            try
            {
                _CmdManager.LcSet(id, false);
            }
            catch (Exception ex)
            {
                int pos = _LcButtons.IndexOf((LcButton)sender);
                string msg = string.Format("ERROR liberando LC [Pos={0}] [Id={1}]", pos, id);
                _Logger.Error(msg, ex);
            }
            _Pulsed = false;
        }

        private void LcView_BackColorChanged(object sender, EventArgs e)
        {
            Invalidate(true);
        }

        private void _SlowBlinkTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (_SlowBlinkTimer.Enabled)
                {
                    _SlowBlinkOn = !_SlowBlinkOn;
                    foreach (KeyValuePair<LcButton, Color> p in _SlowBlinkList)
                    {
                        p.Key.TxBackColor = _SlowBlinkOn ? p.Value : VisualStyle.ButtonColor;
                    }
                }
            }
            catch (Exception ex)
            {
                _Logger.Error("ERROR generando parpadeo lento para teclas LC", ex);
            }
        }

        private void urrPhoneOptions_Click(object sender, EventArgs e)
        {

        }



    }
}

