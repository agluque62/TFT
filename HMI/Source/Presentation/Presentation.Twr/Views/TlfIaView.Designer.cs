
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

namespace HMI.Presentation.Twr.Views
{
	partial class TlfIaView
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
			System.Windows.Forms.TableLayoutPanel _TlfIaTLP;
			System.Windows.Forms.TableLayoutPanel _IaFunctionsTLP;
			this._IaToolsWS = new Microsoft.Practices.CompositeUI.WinForms.DeckWorkspace();
			this._MemBT = new HMI.Model.Module.UI.HMIButton();
			this._CallBT = new HMI.Model.Module.UI.HMIButton();
			this._Num1BT = new HMI.Model.Module.UI.HMIButton();
			this._Num2BT = new HMI.Model.Module.UI.HMIButton();
			this._Num3BT = new HMI.Model.Module.UI.HMIButton();
			this._Num4BT = new HMI.Model.Module.UI.HMIButton();
			this._SlowBlinkTimer = new System.Windows.Forms.Timer(this.components);
			_TlfIaTLP = new System.Windows.Forms.TableLayoutPanel();
			_IaFunctionsTLP = new System.Windows.Forms.TableLayoutPanel();
			_TlfIaTLP.SuspendLayout();
			_IaFunctionsTLP.SuspendLayout();
			this.SuspendLayout();
			// 
			// _TlfIaTLP
			// 
			_TlfIaTLP.ColumnCount = 2;
			_TlfIaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
			_TlfIaTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
			_TlfIaTLP.Controls.Add(this._IaToolsWS, 0, 0);
			_TlfIaTLP.Controls.Add(_IaFunctionsTLP, 1, 0);
			_TlfIaTLP.Dock = System.Windows.Forms.DockStyle.Fill;
			_TlfIaTLP.Location = new System.Drawing.Point(0, 0);
			_TlfIaTLP.Margin = new System.Windows.Forms.Padding(0);
			_TlfIaTLP.Name = "_TlfIaTLP";
			_TlfIaTLP.RowCount = 1;
			_TlfIaTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			_TlfIaTLP.Size = new System.Drawing.Size(440, 350);
			_TlfIaTLP.TabIndex = 4;
			// 
			// _IaToolsWS
			// 
			this._IaToolsWS.Dock = System.Windows.Forms.DockStyle.Fill;
			this._IaToolsWS.Location = new System.Drawing.Point(10, 10);
			this._IaToolsWS.Margin = new System.Windows.Forms.Padding(10);
			this._IaToolsWS.Name = "_IaToolsWS";
			this._IaToolsWS.Size = new System.Drawing.Size(222, 330);
			this._IaToolsWS.TabIndex = 5;
			this._IaToolsWS.Text = "deckWorkspace3";
			// 
			// _IaFunctionsTLP
			// 
			_IaFunctionsTLP.ColumnCount = 2;
			_IaFunctionsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			_IaFunctionsTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			_IaFunctionsTLP.Controls.Add(this._MemBT, 0, 0);
			_IaFunctionsTLP.Controls.Add(this._CallBT, 1, 0);
			_IaFunctionsTLP.Controls.Add(this._Num1BT, 0, 2);
			_IaFunctionsTLP.Controls.Add(this._Num2BT, 1, 2);
			_IaFunctionsTLP.Controls.Add(this._Num3BT, 0, 3);
			_IaFunctionsTLP.Controls.Add(this._Num4BT, 1, 3);
			_IaFunctionsTLP.Dock = System.Windows.Forms.DockStyle.Fill;
			_IaFunctionsTLP.Location = new System.Drawing.Point(252, 0);
			_IaFunctionsTLP.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
			_IaFunctionsTLP.Name = "_IaFunctionsTLP";
			_IaFunctionsTLP.RowCount = 4;
			_IaFunctionsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			_IaFunctionsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			_IaFunctionsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			_IaFunctionsTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			_IaFunctionsTLP.Size = new System.Drawing.Size(188, 340);
			_IaFunctionsTLP.TabIndex = 1;
			// 
			// _MemBT
			// 
			this._MemBT.Dock = System.Windows.Forms.DockStyle.Fill;
			this._MemBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._MemBT.Location = new System.Drawing.Point(3, 40);
			this._MemBT.Margin = new System.Windows.Forms.Padding(3, 40, 3, 40);
			this._MemBT.Name = "_MemBT";
			_IaFunctionsTLP.SetRowSpan(this._MemBT, 2);
			this._MemBT.Size = new System.Drawing.Size(88, 90);
			this._MemBT.TabIndex = 0;
			this._MemBT.Text = "MEM";
			this._MemBT.Click += new System.EventHandler(this._MemBT_Click);
			// 
			// _CallBT
			// 
			this._CallBT.Dock = System.Windows.Forms.DockStyle.Fill;
			this._CallBT.Enabled = false;
			this._CallBT.ImageDisabled = global::HMI.Presentation.Twr.Properties.Resources.UnhangDisabled;
			this._CallBT.ImageNormal = global::HMI.Presentation.Twr.Properties.Resources.Unhang;
			this._CallBT.Location = new System.Drawing.Point(97, 40);
			this._CallBT.Margin = new System.Windows.Forms.Padding(3, 40, 3, 40);
			this._CallBT.Name = "_CallBT";
			_IaFunctionsTLP.SetRowSpan(this._CallBT, 2);
			this._CallBT.Size = new System.Drawing.Size(88, 90);
			this._CallBT.TabIndex = 1;
			this._CallBT.Click += new System.EventHandler(this._CallBT_Click);
			// 
			// _Num1BT
			// 
			this._Num1BT.Dock = System.Windows.Forms.DockStyle.Fill;
			this._Num1BT.Enabled = false;
			this._Num1BT.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._Num1BT.Location = new System.Drawing.Point(5, 173);
			this._Num1BT.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
			this._Num1BT.Name = "_Num1BT";
			this._Num1BT.Size = new System.Drawing.Size(86, 79);
			this._Num1BT.TabIndex = 2;
			this._Num1BT.Text = "N�m. 1";
			this._Num1BT.Click += new System.EventHandler(this._NumBT_Click);
			// 
			// _Num2BT
			// 
			this._Num2BT.Dock = System.Windows.Forms.DockStyle.Fill;
			this._Num2BT.Enabled = false;
			this._Num2BT.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._Num2BT.Location = new System.Drawing.Point(97, 173);
			this._Num2BT.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
			this._Num2BT.Name = "_Num2BT";
			this._Num2BT.Size = new System.Drawing.Size(86, 79);
			this._Num2BT.TabIndex = 3;
			this._Num2BT.Text = "N�m. 2";
			this._Num2BT.Click += new System.EventHandler(this._NumBT_Click);
			// 
			// _Num3BT
			// 
			this._Num3BT.Dock = System.Windows.Forms.DockStyle.Fill;
			this._Num3BT.Enabled = false;
			this._Num3BT.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._Num3BT.Location = new System.Drawing.Point(5, 258);
			this._Num3BT.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
			this._Num3BT.Name = "_Num3BT";
			this._Num3BT.Size = new System.Drawing.Size(86, 79);
			this._Num3BT.TabIndex = 4;
			this._Num3BT.Text = "N�m. 3";
			this._Num3BT.Click += new System.EventHandler(this._NumBT_Click);
			// 
			// _Num4BT
			// 
			this._Num4BT.Dock = System.Windows.Forms.DockStyle.Fill;
			this._Num4BT.Enabled = false;
			this._Num4BT.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._Num4BT.Location = new System.Drawing.Point(97, 258);
			this._Num4BT.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
			this._Num4BT.Name = "_Num4BT";
			this._Num4BT.Size = new System.Drawing.Size(86, 79);
			this._Num4BT.TabIndex = 5;
			this._Num4BT.Text = "N�m. 4";
			this._Num4BT.Click += new System.EventHandler(this._NumBT_Click);
			// 
			// _SlowBlinkTimer
			// 
			this._SlowBlinkTimer.Interval = 500;
			this._SlowBlinkTimer.Tick += new System.EventHandler(this._SlowBlinkTimer_Tick);
			// 
			// TlfIaView
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.Controls.Add(_TlfIaTLP);
			this.Name = "TlfIaView";
			this.Size = new System.Drawing.Size(440, 350);
			_TlfIaTLP.ResumeLayout(false);
			_IaFunctionsTLP.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private HMI.Model.Module.UI.HMIButton _MemBT;
		private HMI.Model.Module.UI.HMIButton _CallBT;
		private HMI.Model.Module.UI.HMIButton _Num1BT;
		private HMI.Model.Module.UI.HMIButton _Num2BT;
		private HMI.Model.Module.UI.HMIButton _Num3BT;
		private HMI.Model.Module.UI.HMIButton _Num4BT;
		private Microsoft.Practices.CompositeUI.WinForms.DeckWorkspace _IaToolsWS;
		private System.Windows.Forms.Timer _SlowBlinkTimer;

	}
}

