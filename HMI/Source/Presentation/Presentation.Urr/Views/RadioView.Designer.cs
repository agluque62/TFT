
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

using HMI.Presentation.Urr.Properties;

namespace HMI.Presentation.Urr.Views
{
    partial class RadioView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TableLayoutPanel _RadioTLP;
            this._RadioHeadP = new System.Windows.Forms.Panel();
            this.DivisorLine = new System.Windows.Forms.Label();
            this._urrRdPageButton = new HMI.Model.Module.UI.UrrRdPageButton();
            this._UrrDownPageBT = new HMI.Presentation.Urr.UI.DecreaseButton();
            this._UrrUpPageBT = new HMI.Presentation.Urr.UI.IncreaseButton();
            this._UrrRdHeadPhonesUDB = new HMI.Presentation.Urr.UI.UrrUpDownButton();
            this._UrrRdSpeakerUDB = new HMI.Presentation.Urr.UI.UrrUpDownButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._RdButtonsTLP = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this._RtxBT = new HMI.Model.Module.UI.HMIButton();
            this._PttBT = new HMI.Model.Module.UI.HMIButton();
            this._PttBlinkTimer = new System.Windows.Forms.Timer(this.components);
            this._SquelchBlinkTimer = new System.Windows.Forms.Timer(this.components);
            this._RtxBlinkTimer = new System.Windows.Forms.Timer(this.components);
            //this._TxConfirmationDetectionTimer = new System.Windows.Forms.Timer(this.components);
            //this._CarrierDetectionTimer = new System.Windows.Forms.Timer(this.components);
            this._RtxErrorTimer = new System.Windows.Forms.Timer(this.components);
            _RadioTLP = new System.Windows.Forms.TableLayoutPanel();
            _RadioTLP.SuspendLayout();
            this._RadioHeadP.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _RadioTLP
            // 
            _RadioTLP.BackColor = System.Drawing.Color.Gainsboro;
            _RadioTLP.ColumnCount = 1;
            _RadioTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            _RadioTLP.Controls.Add(this._RadioHeadP, 0, 0);
            _RadioTLP.Controls.Add(this.tableLayoutPanel1, 0, 1);
            _RadioTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            _RadioTLP.Location = new System.Drawing.Point(0, 0);
            _RadioTLP.Name = "_RadioTLP";
            _RadioTLP.RowCount = 2;
            _RadioTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.14894F));
            _RadioTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.85107F));
            _RadioTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            _RadioTLP.Size = new System.Drawing.Size(600, 470);
            _RadioTLP.TabIndex = 0;
            // 
            // _RadioHeadP
            // 
            this._RadioHeadP.Controls.Add(this.DivisorLine);
            this._RadioHeadP.Controls.Add(this._urrRdPageButton);
            this._RadioHeadP.Controls.Add(this._UrrDownPageBT);
            this._RadioHeadP.Controls.Add(this._UrrUpPageBT);
            this._RadioHeadP.Controls.Add(this._UrrRdHeadPhonesUDB);
            this._RadioHeadP.Controls.Add(this._UrrRdSpeakerUDB);
            this._RadioHeadP.Dock = System.Windows.Forms.DockStyle.Fill;
            this._RadioHeadP.Location = new System.Drawing.Point(3, 3);
            this._RadioHeadP.Name = "_RadioHeadP";
            this._RadioHeadP.Size = new System.Drawing.Size(594, 84);
            this._RadioHeadP.TabIndex = 1;
            // 
            // DivisorLine
            // 
            this.DivisorLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DivisorLine.Location = new System.Drawing.Point(7, 71);
            this.DivisorLine.Name = "DivisorLine";
            this.DivisorLine.Size = new System.Drawing.Size(583, 2);
            this.DivisorLine.TabIndex = 11;
            // 
            // _urrRdPageButton
            // 
            this._urrRdPageButton.BorderColorDisabled = System.Drawing.Color.Black;
            this._urrRdPageButton.ButtonColor = System.Drawing.Color.LightGray;
            this._urrRdPageButton.ButtonColorDisabled = System.Drawing.Color.LightGray;
            this._urrRdPageButton.ButtonColorMouseOver = System.Drawing.Color.LightGray;
            this._urrRdPageButton.ButtonColorPushed = System.Drawing.Color.LightGray;
            this._urrRdPageButton.ButtonShape = HMI.Model.Module.UI.UrrRdPageButton.ButtonsShapes.Rect;
            this._urrRdPageButton.Enabled = false;
            this._urrRdPageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._urrRdPageButton.Location = new System.Drawing.Point(308, 7);
            this._urrRdPageButton.Name = "_urrRdPageButton";
            this._urrRdPageButton.Size = new System.Drawing.Size(35, 40);
            this._urrRdPageButton.TabIndex = 10;
            this._urrRdPageButton.Text = "1";
            this._urrRdPageButton.UseVisualStyleBackColor = false;
            // 
            // _UrrDownPageBT
            // 
            this._UrrDownPageBT.BackColor = System.Drawing.Color.Transparent;
            this._UrrDownPageBT.BorderColor = System.Drawing.Color.Black;
            this._UrrDownPageBT.BorderWidth = 1;
            this._UrrDownPageBT.ButtonShape = HMI.Presentation.Urr.UI.DecreaseButton.ButtonsShapes.LeftTriangle;
            this._UrrDownPageBT.ButtonText = "-";
            this._UrrDownPageBT.EndColor = System.Drawing.Color.LightGray;
            this._UrrDownPageBT.FlatAppearance.BorderSize = 0;
            this._UrrDownPageBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._UrrDownPageBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._UrrDownPageBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._UrrDownPageBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._UrrDownPageBT.ForeColor = System.Drawing.Color.Transparent;
            this._UrrDownPageBT.GradientAngle = 90;
            this._UrrDownPageBT.Location = new System.Drawing.Point(272, 5);
            this._UrrDownPageBT.MouseClickColor1 = System.Drawing.Color.White;
            this._UrrDownPageBT.MouseClickColor2 = System.Drawing.Color.Gainsboro;
            this._UrrDownPageBT.Name = "_UrrDownPageBT";
            this._UrrDownPageBT.ShowButtontext = true;
            this._UrrDownPageBT.Size = new System.Drawing.Size(30, 45);
            this._UrrDownPageBT.StartColor = System.Drawing.Color.WhiteSmoke;
            this._UrrDownPageBT.TabIndex = 9;
            this._UrrDownPageBT.Text = "decreaseButton1";
            this._UrrDownPageBT.TextLocation_X = 8;
            this._UrrDownPageBT.TextLocation_Y = 2;
            this._UrrDownPageBT.Transparent1 = 250;
            this._UrrDownPageBT.Transparent2 = 250;
            this._UrrDownPageBT.UseVisualStyleBackColor = false;
            this._UrrDownPageBT.Click += new System.EventHandler(this._UrrDownPageBT_Click);
            // 
            // _UrrUpPageBT
            // 
            this._UrrUpPageBT.BackColor = System.Drawing.Color.Transparent;
            this._UrrUpPageBT.BorderColor = System.Drawing.Color.Black;
            this._UrrUpPageBT.BorderWidth = 1;
            this._UrrUpPageBT.ButtonShape = HMI.Presentation.Urr.UI.IncreaseButton.ButtonsShapes.RightTriangle;
            this._UrrUpPageBT.ButtonText = "+";
            this._UrrUpPageBT.EndColor = System.Drawing.Color.LightGray;
            this._UrrUpPageBT.FlatAppearance.BorderSize = 0;
            this._UrrUpPageBT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this._UrrUpPageBT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this._UrrUpPageBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._UrrUpPageBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._UrrUpPageBT.ForeColor = System.Drawing.Color.Transparent;
            this._UrrUpPageBT.GradientAngle = 90;
            this._UrrUpPageBT.Location = new System.Drawing.Point(349, 5);
            this._UrrUpPageBT.MouseClickColor1 = System.Drawing.Color.White;
            this._UrrUpPageBT.MouseClickColor2 = System.Drawing.Color.Gainsboro;
            //this._UrrUpPageBT.MouseHoverColor1 = System.Drawing.Color.Gainsboro;
            //this._UrrUpPageBT.MouseHoverColor2 = System.Drawing.Color.DarkGray;
            this._UrrUpPageBT.Name = "_UrrUpPageBT";
            this._UrrUpPageBT.ShowButtontext = true;
            this._UrrUpPageBT.Size = new System.Drawing.Size(30, 45);
            this._UrrUpPageBT.StartColor = System.Drawing.Color.WhiteSmoke;
            this._UrrUpPageBT.TabIndex = 8;
            this._UrrUpPageBT.Text = "increaseButton1";
            this._UrrUpPageBT.TextLocation_X = 0;
            this._UrrUpPageBT.TextLocation_Y = 7;
            this._UrrUpPageBT.Transparent1 = 250;
            this._UrrUpPageBT.Transparent2 = 250;
            this._UrrUpPageBT.UseVisualStyleBackColor = false;
            this._UrrUpPageBT.Click += new System.EventHandler(this._UrrUpPageBT_Click);
            // 
            // _UrrRdHeadPhonesUDB
            // 
            this._UrrRdHeadPhonesUDB.BackColor = System.Drawing.Color.Transparent;
            this._UrrRdHeadPhonesUDB.DownImage = global::HMI.Presentation.Urr.Properties.Resources.UrrHeadphones;
            this._UrrRdHeadPhonesUDB.Level = 3;
            this._UrrRdHeadPhonesUDB.Location = new System.Drawing.Point(120, 3);
            this._UrrRdHeadPhonesUDB.Name = "_UrrRdHeadPhonesUDB";
            this._UrrRdHeadPhonesUDB.Size = new System.Drawing.Size(114, 70);
            this._UrrRdHeadPhonesUDB.TabIndex = 6;
            this._UrrRdHeadPhonesUDB.LevelDown += new System.EventHandler(this._RdHeadPhonesUDB_LevelDown);
            this._UrrRdHeadPhonesUDB.LevelUp += new System.EventHandler(this._RdHeadPhonesUDB_LevelUp);
            // 
            // _UrrRdSpeakerUDB
            // 
            this._UrrRdSpeakerUDB.BackColor = System.Drawing.Color.Transparent;
            this._UrrRdSpeakerUDB.DownImage = global::HMI.Presentation.Urr.Properties.Resources.UrrSpeaker;
            this._UrrRdSpeakerUDB.Location = new System.Drawing.Point(0, 3);
            this._UrrRdSpeakerUDB.Name = "_UrrRdSpeakerUDB";
            this._UrrRdSpeakerUDB.Size = new System.Drawing.Size(114, 70);
            this._UrrRdSpeakerUDB.TabIndex = 5;
            this._UrrRdSpeakerUDB.LevelDown += new System.EventHandler(this._RdSpeakerUDB_LevelDown);
            this._UrrRdSpeakerUDB.LevelUp += new System.EventHandler(this._RdSpeakerUDB_LevelUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel1.Controls.Add(this._RdButtonsTLP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 93);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(594, 374);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _RdButtonsTLP
            // 
            this._RdButtonsTLP.ColumnCount = 5;
            this._RdButtonsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._RdButtonsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._RdButtonsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._RdButtonsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._RdButtonsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this._RdButtonsTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this._RdButtonsTLP.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this._RdButtonsTLP.Location = new System.Drawing.Point(109, 3);
            this._RdButtonsTLP.Name = "_RdButtonsTLP";
            this._RdButtonsTLP.RowCount = 3;
            this._RdButtonsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._RdButtonsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._RdButtonsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._RdButtonsTLP.Size = new System.Drawing.Size(482, 368);
            this._RdButtonsTLP.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this._RtxBT, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this._PttBT, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(100, 368);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // _RtxBT
            // 
            this._RtxBT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._RtxBT.Enabled = false;
            this._RtxBT.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._RtxBT.ForeColor = System.Drawing.Color.White;
            this._RtxBT.Location = new System.Drawing.Point(3, 76);
            this._RtxBT.Name = "_RtxBT";
            this._RtxBT.Size = new System.Drawing.Size(78, 67);
            this._RtxBT.TabIndex = 3;
            this._RtxBT.Text = "RTx";
            this._RtxBT.Click += new System.EventHandler(this._RtxBT_Click);
            // 
            // _PttBT
            // 
            this._PttBT.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this._PttBT.ForeColor = System.Drawing.Color.White;
            this._PttBT.Location = new System.Drawing.Point(3, 222);
            this._PttBT.Name = "_PttBT";
            this._PttBT.Size = new System.Drawing.Size(78, 67);
            this._PttBT.TabIndex = 6;
            this._PttBT.Text = "PTT";
            this._PttBT.MouseDown += new System.Windows.Forms.MouseEventHandler(this._PttBT_MouseDown);
            this._PttBT.MouseUp += new System.Windows.Forms.MouseEventHandler(this._PttBT_MouseUp);
            // 
            // _PttBlinkTimer
            // 
            this._PttBlinkTimer.Interval = 500;
            this._PttBlinkTimer.Tick += new System.EventHandler(this._PttBlinkTimer_Tick);
            // 
            // _SquelchBlinkTimer
            // 
            this._SquelchBlinkTimer.Interval = 500;
            this._SquelchBlinkTimer.Tick += new System.EventHandler(this._SquelchBlinkTimer_Tick);
            // 
            // _RtxBlinkTimer
            // 
            this._RtxBlinkTimer.Interval = 500;
            this._RtxBlinkTimer.Tick += new System.EventHandler(this._RtxBlinkTimer_Tick);
            // 
            // _TxConfirmationDetectionTimer
            // 
            //this._TxConfirmationDetectionTimer.Tick += new System.EventHandler(this._TxConfirmationDetectionTimer_Tick);
            // 
            // _CarrierDetectionTimer
            // 
            //this._CarrierDetectionTimer.Tick += new System.EventHandler(this._CarrierDetectionTimer_Tick);
            // 
            // _RtxErrorTimer
            // 
            //this._RtxErrorTimer.Interval = 2000;
            //this._RtxErrorTimer.Tick += new System.EventHandler(this._RtxErrorTimer_Tick);
            // 
            // RadioView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(_RadioTLP);
            this.Name = "RadioView";
            this.Size = new System.Drawing.Size(600, 470);
            this.BackColorChanged += new System.EventHandler(this.RadioView_BackColorChanged);
            _RadioTLP.ResumeLayout(false);
            this._RadioHeadP.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer _PttBlinkTimer;
        private System.Windows.Forms.Timer _SquelchBlinkTimer;
        private System.Windows.Forms.Timer _RtxBlinkTimer;
        private System.Windows.Forms.Timer _RtxErrorTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel _RdButtonsTLP;
        private Model.Module.UI.HMIButton _RtxBT;
        private System.Windows.Forms.Panel _RadioHeadP;
        private UI.UrrUpDownButton _UrrRdSpeakerUDB;
        private UI.UrrUpDownButton _UrrRdHeadPhonesUDB;
        private UI.DecreaseButton _UrrDownPageBT;
        private UI.IncreaseButton _UrrUpPageBT;
        private Model.Module.UI.UrrRdPageButton _urrRdPageButton;
        private Model.Module.UI.HMIButton _PttBT;
        private System.Windows.Forms.Label DivisorLine;
        //private System.Windows.Forms.Timer _TxConfirmationDetectionTimer;
        //private System.Windows.Forms.Timer _CarrierDetectionTimer;
    }
}
