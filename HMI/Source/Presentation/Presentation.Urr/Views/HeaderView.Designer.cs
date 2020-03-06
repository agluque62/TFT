
//----------------------------------------------------------------------------------------
// patterns & practices - Smart Client Software Factory - Guidance Package
//
// This file was generated by the "Add View" recipe.
//
// For more information see: 
// ms-help://MS.VSCC.v80/MS.VSIPCC.v80/ms.practices.scsf.2007may/SCSF/html/02-09-010-ModelViewPresenter_MVP.htm
//
// Latest version of this Guidance Package: http://go.microsoft.com/fwlink/?LinkId=62182
//----------------------------------------------------------------------------------------

namespace HMI.Presentation.Urr.Views
{
    partial class HeaderView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                    components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._MsgLB = new System.Windows.Forms.ListBox();
            this._PosMsgLB = new System.Windows.Forms.TextBox();
            this._TitleBT = new HMI.Model.Module.UI.HMIButton();
            this._UrrBrightnessUDB = new HMI.Presentation.Urr.UI.UrrUpDownButton();
            this._UrrBuzzerUDB = new HMI.Presentation.Urr.UI.UrrUpDownButton();
            this._SplitUC = new HMI.Presentation.Urr.UI.UrrSplitUC();
            this._InfoBT = new HMI.Model.Module.UI.HMIButton();
            this.SuspendLayout();
            // 
            // _MsgLB
            // 
            this._MsgLB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._MsgLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._MsgLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._MsgLB.FormattingEnabled = true;
            this._MsgLB.ItemHeight = 15;
            this._MsgLB.Location = new System.Drawing.Point(280, 10);
            this._MsgLB.Name = "_MsgLB";
            this._MsgLB.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this._MsgLB.Size = new System.Drawing.Size(240, 64);
            this._MsgLB.TabIndex = 5;
            // 
            // _PosMsgLB
            // 
            this._PosMsgLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this._PosMsgLB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._PosMsgLB.Location = new System.Drawing.Point(60, 10);
            this._PosMsgLB.Multiline = true;
            this._PosMsgLB.Name = "_PosMsgLB";
            this._PosMsgLB.ReadOnly = true;
            this._PosMsgLB.Size = new System.Drawing.Size(150, 56);
            this._PosMsgLB.TabIndex = 11;
            this._PosMsgLB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _TitleBT
            // 
            this._TitleBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this._TitleBT.ForeColor = System.Drawing.Color.White;
            this._TitleBT.Location = new System.Drawing.Point(0, 12);
            this._TitleBT.Name = "_TitleBT";
            this._TitleBT.Size = new System.Drawing.Size(57, 52);
            this._TitleBT.TabIndex = 12;
            this._TitleBT.Text = "TFT";
            this._TitleBT.Click += new System.EventHandler(this._TitleBT_Click);
            // 
            // _UrrBrightnessUDB
            // 
            this._UrrBrightnessUDB.BackColor = System.Drawing.Color.Transparent;
            this._UrrBrightnessUDB.DownImage = global::HMI.Presentation.Urr.Properties.Resources.UrrBrigthness;
            this._UrrBrightnessUDB.Level = 1;
            this._UrrBrightnessUDB.Location = new System.Drawing.Point(627, 0);
            this._UrrBrightnessUDB.Name = "_UrrBrightnessUDB";
            this._UrrBrightnessUDB.Size = new System.Drawing.Size(114, 70);
            this._UrrBrightnessUDB.TabIndex = 10;
            this._UrrBrightnessUDB.LevelDown += new System.EventHandler(this._BrightnessUDB_LevelDown);
            this._UrrBrightnessUDB.LevelUp += new System.EventHandler(this._BrightnessUDB_LevelUp);
            // 
            // _UrrBuzzerUDB
            // 
            this._UrrBuzzerUDB.BackColor = System.Drawing.Color.Transparent;
            this._UrrBuzzerUDB.DownImage = global::HMI.Presentation.Urr.Properties.Resources.UrrBuzzer;
            this._UrrBuzzerUDB.Level = 1;
            this._UrrBuzzerUDB.Location = new System.Drawing.Point(518, 0);
            this._UrrBuzzerUDB.Name = "_UrrBuzzerUDB";
            this._UrrBuzzerUDB.Size = new System.Drawing.Size(114, 70);
            this._UrrBuzzerUDB.TabIndex = 9;
            this._UrrBuzzerUDB.LevelDown += new System.EventHandler(this._BuzzerUDB_LevelDown);
            this._UrrBuzzerUDB.LevelUp += new System.EventHandler(this._BuzzerUDB_LevelUp);
            // 
            // _SplitUC
            // 
            this._SplitUC.JackOff = global::HMI.Presentation.Urr.Properties.Resources.UrrJackOff;
            this._SplitUC.JackOn = global::HMI.Presentation.Urr.Properties.Resources.UrrJackOn;
            this._SplitUC.Location = new System.Drawing.Point(215, 5);
            this._SplitUC.Margin = new System.Windows.Forms.Padding(0);
            this._SplitUC.Name = "_SplitUC";
            this._SplitUC.Size = new System.Drawing.Size(60, 60);
            this._SplitUC.TabIndex = 7;
            // 
            // _InfoBT
            // 
            this._InfoBT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._InfoBT.ButtonColorMouseOver = System.Drawing.Color.Silver;
            this._InfoBT.ButtonColorPushed = System.Drawing.Color.Silver;
            this._InfoBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._InfoBT.ForeColor = System.Drawing.Color.White;
            this._InfoBT.Location = new System.Drawing.Point(743, 12);
            this._InfoBT.Name = "_InfoBT";
            this._InfoBT.Size = new System.Drawing.Size(54, 53);
            this._InfoBT.TabIndex = 2;
            this._InfoBT.Text = "INFO";
            // 
            // HeaderView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this._TitleBT);
            this.Controls.Add(this._PosMsgLB);
            this.Controls.Add(this._UrrBrightnessUDB);
            this.Controls.Add(this._UrrBuzzerUDB);
            this.Controls.Add(this._SplitUC);
            this.Controls.Add(this._MsgLB);
            this.Controls.Add(this._InfoBT);
            this.Name = "HeaderView";
            this.Size = new System.Drawing.Size(800, 86);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HMI.Model.Module.UI.HMIButton _InfoBT;
        private System.Windows.Forms.ListBox _MsgLB;
        private UI.UrrSplitUC _SplitUC;
        private UI.UrrUpDownButton _UrrBuzzerUDB;
        private UI.UrrUpDownButton _UrrBrightnessUDB;
        private System.Windows.Forms.TextBox _PosMsgLB;
        private Model.Module.UI.HMIButton _TitleBT;
    }
}
