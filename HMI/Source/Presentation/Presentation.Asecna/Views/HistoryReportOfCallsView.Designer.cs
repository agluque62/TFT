
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

namespace HMI.Presentation.Asecna.Views
{
	partial class HistoryReportOfCalls
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
            System.Windows.Forms.TableLayoutPanel HistoryReportOfCalls_TLP;
            System.Windows.Forms.Panel panel1;
            this._LblTextLastCall = new System.Windows.Forms.Label();
            this._LblTitleLastCall = new System.Windows.Forms.Label();
            this._LVCalls = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._TitleLB = new System.Windows.Forms.Label();
            this._BtnDependencesView = new System.Windows.Forms.Button();
            this._CloseBT = new HMI.Model.Module.UI.HMIButton();
            this._RBNotAnswered = new System.Windows.Forms.RadioButton();
            this._RBOutgoing = new System.Windows.Forms.RadioButton();
            this._RBIncomming = new System.Windows.Forms.RadioButton();
            HistoryReportOfCalls_TLP = new System.Windows.Forms.TableLayoutPanel();
            panel1 = new System.Windows.Forms.Panel();
            HistoryReportOfCalls_TLP.SuspendLayout();
            panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HistoryReportOfCalls_TLP
            // 
            HistoryReportOfCalls_TLP.BackColor = System.Drawing.SystemColors.Control;
            HistoryReportOfCalls_TLP.ColumnCount = 2;
            HistoryReportOfCalls_TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            HistoryReportOfCalls_TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            HistoryReportOfCalls_TLP.Controls.Add(this._LblTextLastCall, 0, 4);
            HistoryReportOfCalls_TLP.Controls.Add(this._LblTitleLastCall, 0, 3);
            HistoryReportOfCalls_TLP.Controls.Add(this._LVCalls, 0, 2);
            HistoryReportOfCalls_TLP.Controls.Add(this._TitleLB, 1, 0);
            HistoryReportOfCalls_TLP.Controls.Add(this._BtnDependencesView, 0, 0);
            HistoryReportOfCalls_TLP.Controls.Add(this._CloseBT, 1, 3);
            HistoryReportOfCalls_TLP.Controls.Add(panel1, 0, 1);
            HistoryReportOfCalls_TLP.Dock = System.Windows.Forms.DockStyle.Fill;
            HistoryReportOfCalls_TLP.Location = new System.Drawing.Point(0, 0);
            HistoryReportOfCalls_TLP.Margin = new System.Windows.Forms.Padding(0);
            HistoryReportOfCalls_TLP.Name = "HistoryReportOfCalls_TLP";
            HistoryReportOfCalls_TLP.RowCount = 5;
            HistoryReportOfCalls_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            HistoryReportOfCalls_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            HistoryReportOfCalls_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            HistoryReportOfCalls_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            HistoryReportOfCalls_TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            HistoryReportOfCalls_TLP.Size = new System.Drawing.Size(440, 462);
            HistoryReportOfCalls_TLP.TabIndex = 0;
            // 
            // _LblTextLastCall
            // 
            this._LblTextLastCall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._LblTextLastCall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._LblTextLastCall.Dock = System.Windows.Forms.DockStyle.Fill;
            this._LblTextLastCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._LblTextLastCall.Location = new System.Drawing.Point(5, 435);
            this._LblTextLastCall.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this._LblTextLastCall.Name = "_LblTextLastCall";
            this._LblTextLastCall.Size = new System.Drawing.Size(210, 24);
            this._LblTextLastCall.TabIndex = 14;
            this._LblTextLastCall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _LblTitleLastCall
            // 
            this._LblTitleLastCall.BackColor = System.Drawing.Color.Lime;
            this._LblTitleLastCall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._LblTitleLastCall.Dock = System.Windows.Forms.DockStyle.Fill;
            this._LblTitleLastCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._LblTitleLastCall.Location = new System.Drawing.Point(5, 408);
            this._LblTitleLastCall.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this._LblTitleLastCall.Name = "_LblTitleLastCall";
            this._LblTitleLastCall.Size = new System.Drawing.Size(210, 21);
            this._LblTitleLastCall.TabIndex = 13;
            this._LblTitleLastCall.Text = "Ultima llamada";
            this._LblTitleLastCall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _LVCalls
            // 
            this._LVCalls.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            HistoryReportOfCalls_TLP.SetColumnSpan(this._LVCalls, 2);
            this._LVCalls.Dock = System.Windows.Forms.DockStyle.Fill;
            this._LVCalls.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._LVCalls.FullRowSelect = true;
            this._LVCalls.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this._LVCalls.HideSelection = false;
            this._LVCalls.Location = new System.Drawing.Point(3, 62);
            this._LVCalls.MultiSelect = false;
            this._LVCalls.Name = "_LVCalls";
            this._LVCalls.Size = new System.Drawing.Size(434, 340);
            this._LVCalls.TabIndex = 12;
            this._LVCalls.UseCompatibleStateImageBehavior = false;
            this._LVCalls.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DateTime";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Source";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Colateral";
            this.columnHeader3.Width = 120;
            // 
            // _TitleLB
            // 
            this._TitleLB.BackColor = System.Drawing.Color.Lime;
            this._TitleLB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._TitleLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this._TitleLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TitleLB.Location = new System.Drawing.Point(225, 3);
            this._TitleLB.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this._TitleLB.Name = "_TitleLB";
            this._TitleLB.Size = new System.Drawing.Size(210, 30);
            this._TitleLB.TabIndex = 10;
            this._TitleLB.Text = "Hist�rico de llamadas";
            this._TitleLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _BtnDependencesView
            // 
            this._BtnDependencesView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this._BtnDependencesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._BtnDependencesView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._BtnDependencesView.Location = new System.Drawing.Point(3, 3);
            this._BtnDependencesView.Name = "_BtnDependencesView";
            this._BtnDependencesView.Size = new System.Drawing.Size(214, 30);
            this._BtnDependencesView.TabIndex = 4;
            this._BtnDependencesView.Text = "Dependencias-usuario";
            this._BtnDependencesView.UseVisualStyleBackColor = false;
            this._BtnDependencesView.Click += new System.EventHandler(this._BtnDependencesView_Click);
            // 
            // _CloseBT
            // 
            this._CloseBT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._CloseBT.Location = new System.Drawing.Point(367, 421);
            this._CloseBT.Name = "_CloseBT";
            HistoryReportOfCalls_TLP.SetRowSpan(this._CloseBT, 2);
            this._CloseBT.Size = new System.Drawing.Size(70, 38);
            this._CloseBT.TabIndex = 9;
            this._CloseBT.Text = "Cerrar";
            this._CloseBT.Click += new System.EventHandler(this._CloseBT_Click);
            // 
            // panel1
            // 
            HistoryReportOfCalls_TLP.SetColumnSpan(panel1, 2);
            panel1.Controls.Add(this._RBNotAnswered);
            panel1.Controls.Add(this._RBOutgoing);
            panel1.Controls.Add(this._RBIncomming);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(3, 39);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(434, 17);
            panel1.TabIndex = 11;
            // 
            // _RBNotAnswered
            // 
            this._RBNotAnswered.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._RBNotAnswered.AutoSize = true;
            this._RBNotAnswered.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._RBNotAnswered.Location = new System.Drawing.Point(234, -3);
            this._RBNotAnswered.Name = "_RBNotAnswered";
            this._RBNotAnswered.Size = new System.Drawing.Size(110, 21);
            this._RBNotAnswered.TabIndex = 2;
            this._RBNotAnswered.Text = "No atendidas";
            this._RBNotAnswered.UseVisualStyleBackColor = true;
            this._RBNotAnswered.CheckedChanged += new System.EventHandler(this.CallType_CheckedChanged);
            // 
            // _RBOutgoing
            // 
            this._RBOutgoing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._RBOutgoing.AutoSize = true;
            this._RBOutgoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._RBOutgoing.Location = new System.Drawing.Point(128, -2);
            this._RBOutgoing.Name = "_RBOutgoing";
            this._RBOutgoing.Size = new System.Drawing.Size(84, 21);
            this._RBOutgoing.TabIndex = 1;
            this._RBOutgoing.Text = "Salientes";
            this._RBOutgoing.UseVisualStyleBackColor = true;
            this._RBOutgoing.CheckedChanged += new System.EventHandler(this.CallType_CheckedChanged);
            // 
            // _RBIncomming
            // 
            this._RBIncomming.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._RBIncomming.AutoSize = true;
            this._RBIncomming.Checked = true;
            this._RBIncomming.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._RBIncomming.Location = new System.Drawing.Point(3, -2);
            this._RBIncomming.Name = "_RBIncomming";
            this._RBIncomming.Size = new System.Drawing.Size(87, 21);
            this._RBIncomming.TabIndex = 0;
            this._RBIncomming.TabStop = true;
            this._RBIncomming.Text = "Entrantes";
            this._RBIncomming.UseVisualStyleBackColor = true;
            this._RBIncomming.CheckedChanged += new System.EventHandler(this.CallType_CheckedChanged);
            // 
            // HistoryReportOfCalls
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(HistoryReportOfCalls_TLP);
            this.Name = "HistoryReportOfCalls";
            this.Size = new System.Drawing.Size(440, 462);
            this.BackColorChanged += new System.EventHandler(this.HistoryReportOfCalls_BackColorChanged);
            HistoryReportOfCalls_TLP.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

        private Model.Module.UI.HMIButton _CloseBT;
        private System.Windows.Forms.Button _BtnDependencesView;
        private System.Windows.Forms.RadioButton _RBIncomming;
        private System.Windows.Forms.RadioButton _RBOutgoing;
        private System.Windows.Forms.RadioButton _RBNotAnswered;
        private System.Windows.Forms.ListView _LVCalls;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label _LblTextLastCall;
        private System.Windows.Forms.Label _TitleLB;
        private System.Windows.Forms.Label _LblTitleLastCall;


        // Miguel 
        

	}
}
