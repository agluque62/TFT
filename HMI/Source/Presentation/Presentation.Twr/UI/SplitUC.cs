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
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.ObjectBuilder;
using HMI.Infrastructure.Interface;
using HMI.Model.Module.BusinessEntities;
using HMI.Model.Module.UI;
using Utilities;

namespace HMI.Presentation.Twr.UI
{
	public partial class SplitUC : UserControl
	{
		private SplitMode _Mode = SplitMode.Off;
		private HMIButton _ModeBt = null;
		private Image _JackOff = null;
		private Image _JackOn = null;
		private bool _LeftJackOn = false;
		private bool _RightJackOn = false;

		public event EventHandler SplitSelectionClick;
		public event GenericEventHandler<SplitMode> SplitModeChanging;

		[CategoryAttribute("Appearance"),
		Description("Image of jack off"),
		RefreshProperties(RefreshProperties.Repaint),
		DefaultValue(null)
		]
		public Image JackOff
		{
			get { return _JackOff; }
			set 
			{ 
				_JackOff = value;
				if (!_LeftJackOn)
				{
					_Jack1PB.BackgroundImage = value;
					_Jack2PB.BackgroundImage = value;
				}
				if (!_RightJackOn)
				{
					_Jack3PB.BackgroundImage = value;
					_Jack4PB.BackgroundImage = value;
				}
			}
		}

		[CategoryAttribute("Appearance"),
		Description("Image of jack on"),
		RefreshProperties(RefreshProperties.Repaint),
		DefaultValue(null)
		]
		public Image JackOn
		{
			get { return _JackOn; }
			set 
			{ 
				_JackOn = value;
				if (_LeftJackOn)
				{
					_Jack1PB.BackgroundImage = value;
					_Jack2PB.BackgroundImage = value;
				}
				if (_RightJackOn)
				{
					_Jack3PB.BackgroundImage = value;
					_Jack4PB.BackgroundImage = value;
				}
			}
		}

		[Browsable(false),
		DefaultValue(typeof(SplitMode), "Off")
		]
		public SplitMode Mode
		{
			get { return _Mode; }
			set
			{
				if (_Mode != value)
				{
					_ModeBt.ButtonColor = VisualStyle.ButtonColor;

					_Mode = value;
					_ModeBt = (_Mode == SplitMode.Off ? _SplitOffBT : _Mode == SplitMode.LcTf ? _SplitLcTfBT : _SplitRdLcBT);
					_ModeBt.ButtonColor = VisualStyle.Colors.Green;
					_SplitBT.ImageNormal = _ModeBt.ImageNormal;
				}
			}
		}

		[Browsable(false),
		DefaultValue(false)
		]
		public bool LeftJackOn
		{
			get { return _LeftJackOn; }
			set
			{
				if (_LeftJackOn != value)
				{
					_LeftJackOn = value;
					_Jack1PB.BackgroundImage = _LeftJackOn ? _JackOn : _JackOff;
					_Jack2PB.BackgroundImage = _LeftJackOn ? _JackOn : _JackOff;

					if (!_LeftJackOn)
					{
						HideModeSelection();
					}
				}
			}
		}

		[Browsable(false),
		DefaultValue(false)
		]
		public bool RightJackOn
		{
			get { return _RightJackOn; }
			set
			{
				if (_RightJackOn != value)
				{
					_RightJackOn = value;
					_Jack3PB.BackgroundImage = _RightJackOn ? _JackOn : _JackOff;
					_Jack4PB.BackgroundImage = _RightJackOn ? _JackOn : _JackOff;

					if (!_RightJackOn)
					{
						HideModeSelection();
					}
				}
			}
		}

		public SplitUC()
		{
			InitializeComponent();
            if (global::HMI.Presentation.Twr.Properties.Settings.Default.JackUse != HMI.Presentation.Twr.Constants.JackUse.Both)
            {
                this._SplitTLP.Controls.Clear();
                this._SplitTLP.ColumnStyles.Clear();
                this._SplitTLP.ColumnCount = 2;
                this._SplitTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
                this._SplitTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
       
                if (global::HMI.Presentation.Twr.Properties.Settings.Default.JackUse == HMI.Presentation.Twr.Constants.JackUse.ExecutiveOnly)
                {
                    this._SplitTLP.Controls.Add(this._Jack1PB, 0, 0);
                    this._SplitTLP.Controls.Add(this._Jack2PB, 1, 0);
                }
                else
                {
                    this._SplitTLP.Controls.Add(this._Jack3PB, 0, 0);
                    this._SplitTLP.Controls.Add(this._Jack4PB, 1, 0);
                }
            }
            _Jack1PB.Visible = global::HMI.Presentation.Twr.Properties.Settings.Default.JackUse != HMI.Presentation.Twr.Constants.JackUse.AssistantOnly;
            _Jack2PB.Visible = global::HMI.Presentation.Twr.Properties.Settings.Default.JackUse != HMI.Presentation.Twr.Constants.JackUse.AssistantOnly;
            _Jack3PB.Visible = global::HMI.Presentation.Twr.Properties.Settings.Default.JackUse != HMI.Presentation.Twr.Constants.JackUse.ExecutiveOnly;
            _Jack4PB.Visible = global::HMI.Presentation.Twr.Properties.Settings.Default.JackUse != HMI.Presentation.Twr.Constants.JackUse.ExecutiveOnly;
            _SplitBT.Visible = global::HMI.Presentation.Twr.Properties.Settings.Default.JackUse == HMI.Presentation.Twr.Constants.JackUse.Both;

            _ModeBt = _SplitOffBT;
			_ModeBt.ButtonColor = VisualStyle.Colors.Green;
			_SplitBT.ImageNormal = _ModeBt.ImageNormal;

			_SplitOffBT.Tag = SplitMode.Off;
			_SplitRdLcBT.Tag = SplitMode.RdLc;
			_SplitLcTfBT.Tag = SplitMode.LcTf;
		}

		public void ShowModeSelection()
		{
			_SplitTLP.Visible = false;
			_SplitTLP.Dock = DockStyle.None;
			_SplitSelTLP.Dock = DockStyle.Fill;
			_SplitSelTLP.Visible = true;
		}

		public void HideModeSelection()
		{
			if (_SplitSelTLP.Visible)
			{
				_SplitSelTLP.Visible = false;
				_SplitSelTLP.Dock = DockStyle.None;
				_SplitTLP.Visible = true;
				_SplitTLP.Dock = DockStyle.Fill;
			}
		}

		protected override void OnLoad(EventArgs e)
		{
			_SplitTLP.Dock = DockStyle.Fill;

			base.OnLoad(e);
		}

		private void _SplitBT_Click(object sender, EventArgs e)
		{
			General.SafeLaunchEvent(SplitSelectionClick, this);
		}

		private void _SplitModeBT_Click(object sender, EventArgs e)
		{
			SplitMode mode = (SplitMode)((HMIButton)sender).Tag;

			if (mode != _Mode)
			{
				General.SafeLaunchEvent(SplitModeChanging, this, mode);
			}

			HideModeSelection();
		}
    }
}

