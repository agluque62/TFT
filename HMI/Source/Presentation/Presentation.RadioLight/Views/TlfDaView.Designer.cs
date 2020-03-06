
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

namespace HMI.Presentation.RadioLight.Views
{
	partial class TlfDaView
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
            System.Windows.Forms.Panel _TlfHeadP;
            this._TlfPageSecondBT = new HMI.Model.Module.UI.HMIButton();
            this._TlfPageFirstBT = new HMI.Model.Module.UI.HMIButton();
            this._TlfHeadPhonesUDB = new HMI.Presentation.RadioLight.UI.UpDownButton();
            this._LcSpeakerUDB = new HMI.Presentation.RadioLight.UI.UpDownButton();
            this._TlfDaTLP = new System.Windows.Forms.TableLayoutPanel();
            this._TlfButtonsTLP = new System.Windows.Forms.TableLayoutPanel();
            this._FastBlinkTimer = new System.Windows.Forms.Timer(this.components);
            this._SlowBlinkTimer = new System.Windows.Forms.Timer(this.components);
            _TlfHeadP = new System.Windows.Forms.Panel();
            _TlfHeadP.SuspendLayout();
            this._TlfDaTLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // _TlfHeadP
            // 
            _TlfHeadP.Controls.Add(this._TlfPageSecondBT);
            _TlfHeadP.Controls.Add(this._TlfPageFirstBT);
            _TlfHeadP.Controls.Add(this._TlfHeadPhonesUDB);
            _TlfHeadP.Controls.Add(this._LcSpeakerUDB);
            _TlfHeadP.Dock = System.Windows.Forms.DockStyle.Fill;
            _TlfHeadP.Location = new System.Drawing.Point(5, 3);
            _TlfHeadP.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            _TlfHeadP.Name = "_TlfHeadP";
            _TlfHeadP.Size = new System.Drawing.Size(432, 76);
            _TlfHeadP.TabIndex = 0;
            // 
            // _TlfPageSecondBT
            // 
            this._TlfPageSecondBT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._TlfPageSecondBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TlfPageSecondBT.ImageNormal = global::HMI.Presentation.RadioLight.Properties.Resources.TlfPage;
            this._TlfPageSecondBT.Location = new System.Drawing.Point(374, 3);
            this._TlfPageSecondBT.Name = "_TlfPageSecondBT";
            this._TlfPageSecondBT.Size = new System.Drawing.Size(55, 73);
            this._TlfPageSecondBT.TabIndex = 3;
            this._TlfPageSecondBT.Text = "3";
            this._TlfPageSecondBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._TlfPageSecondBT.Click += new System.EventHandler(this._TlfPageSecondBT_Click);
            // 
            // _TlfPageFirstBT
            // 
            this._TlfPageFirstBT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._TlfPageFirstBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TlfPageFirstBT.ImageNormal = global::HMI.Presentation.RadioLight.Properties.Resources.TlfPage;
            this._TlfPageFirstBT.Location = new System.Drawing.Point(313, 3);
            this._TlfPageFirstBT.Name = "_TlfPageFirstBT";
            this._TlfPageFirstBT.Size = new System.Drawing.Size(55, 73);
            this._TlfPageFirstBT.TabIndex = 2;
            this._TlfPageFirstBT.Text = "2";
            this._TlfPageFirstBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._TlfPageFirstBT.Click += new System.EventHandler(this._TlfPageFirstBT_Click);
            // 
            // _TlfHeadPhonesUDB
            // 
            this._TlfHeadPhonesUDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._TlfHeadPhonesUDB.BackColor = System.Drawing.Color.Transparent;
            this._TlfHeadPhonesUDB.DownImage = global::HMI.Presentation.RadioLight.Properties.Resources.HeadPhonesDown;
            this._TlfHeadPhonesUDB.Enabled = false;
            this._TlfHeadPhonesUDB.Location = new System.Drawing.Point(94, 3);
            this._TlfHeadPhonesUDB.Name = "_TlfHeadPhonesUDB";
            this._TlfHeadPhonesUDB.Size = new System.Drawing.Size(85, 70);
            this._TlfHeadPhonesUDB.TabIndex = 1;
            this._TlfHeadPhonesUDB.UpImage = global::HMI.Presentation.RadioLight.Properties.Resources.HeadPhonesUp;
            this._TlfHeadPhonesUDB.LevelDown += new System.EventHandler(this._TlfHeadPhonesUDB_LevelDown);
            this._TlfHeadPhonesUDB.LevelUp += new System.EventHandler(this._TlfHeadPhonesUDB_LevelUp);
            // 
            // _LcSpeakerUDB
            // 
            this._LcSpeakerUDB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._LcSpeakerUDB.BackColor = System.Drawing.Color.Transparent;
            this._LcSpeakerUDB.DownImage = global::HMI.Presentation.RadioLight.Properties.Resources.SpeakerDown;
            this._LcSpeakerUDB.Enabled = false;
            this._LcSpeakerUDB.Location = new System.Drawing.Point(3, 3);
            this._LcSpeakerUDB.Name = "_LcSpeakerUDB";
            this._LcSpeakerUDB.Size = new System.Drawing.Size(85, 70);
            this._LcSpeakerUDB.TabIndex = 0;
            this._LcSpeakerUDB.UpImage = global::HMI.Presentation.RadioLight.Properties.Resources.SpeakerUp;
            this._LcSpeakerUDB.LevelDown += new System.EventHandler(this._LcSpeakerUDB_LevelDown);
            this._LcSpeakerUDB.LevelUp += new System.EventHandler(this._LcSpeakerUDB_LevelUp);
            // 
            // _TlfDaTLP
            // 
            this._TlfDaTLP.ColumnCount = 1;
            this._TlfDaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._TlfDaTLP.Controls.Add(_TlfHeadP, 0, 0);
            this._TlfDaTLP.Controls.Add(this._TlfButtonsTLP, 0, 1);
            this._TlfDaTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this._TlfDaTLP.Location = new System.Drawing.Point(0, 0);
            this._TlfDaTLP.Margin = new System.Windows.Forms.Padding(0);
            this._TlfDaTLP.Name = "_TlfDaTLP";
            this._TlfDaTLP.RowCount = 2;
            this._TlfDaTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.0F));
            this._TlfDaTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.0F));
            this._TlfDaTLP.Size = new System.Drawing.Size(440, 350);
            this._TlfDaTLP.TabIndex = 0;
            // 
            // _TlfButtonsTLP
            // 
            this._TlfButtonsTLP.ColumnCount = 4;
            this._TlfButtonsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._TlfButtonsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._TlfButtonsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._TlfButtonsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._TlfButtonsTLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this._TlfButtonsTLP.Font = new System.Drawing.Font("Trebuchet MS", 7.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TlfButtonsTLP.Location = new System.Drawing.Point(5, 82);
            this._TlfButtonsTLP.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this._TlfButtonsTLP.Name = "_TlfButtonsTLP";
            this._TlfButtonsTLP.RowCount = 4;
            this._TlfButtonsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._TlfButtonsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._TlfButtonsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._TlfButtonsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._TlfButtonsTLP.Size = new System.Drawing.Size(435, 268);
            this._TlfButtonsTLP.TabIndex = 2;
            // 
            // _FastBlinkTimer
            // 
            this._FastBlinkTimer.Interval = 250;
            this._FastBlinkTimer.Tick += new System.EventHandler(this._FastBlinkTimer_Tick);
            // 
            // _SlowBlinkTimer
            // 
            this._SlowBlinkTimer.Interval = 500;
            this._SlowBlinkTimer.Tick += new System.EventHandler(this._SlowBlinkTimer_Tick);
            // 
            // TlfDaView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this._TlfDaTLP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TlfDaView";
            this.Size = new System.Drawing.Size(440, 350);
            _TlfHeadP.ResumeLayout(false);
            this._TlfDaTLP.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private HMI.Model.Module.UI.HMIButton _TlfPageFirstBT;
		private HMI.Model.Module.UI.HMIButton _TlfPageSecondBT;
		private HMI.Presentation.RadioLight.UI.UpDownButton _TlfHeadPhonesUDB;
		private HMI.Presentation.RadioLight.UI.UpDownButton _LcSpeakerUDB;
		private System.Windows.Forms.TableLayoutPanel _TlfButtonsTLP;
		private System.Windows.Forms.TableLayoutPanel _TlfDaTLP;
		private System.Windows.Forms.Timer _FastBlinkTimer;
		private System.Windows.Forms.Timer _SlowBlinkTimer;


	}
}
