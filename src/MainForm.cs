using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using vJoyInterfaceWrap;

namespace MouseMoveToVirtualPadInput
{
	public partial class MainForm : Form
	{
		// ----------------------------------------------------------------------------------------
		private enum vJoyButton : uint
		{
			None = 0,
			Button_1,
			Button_2,
			Button_3,
			Button_4,
			Button_5,
			Button_6,
			Button_7,
			Button_8,
			Button_9,
			Button_10,
			Button_11,
			Button_12,
			Button_13,
			Button_14,
			Button_15,
		}

		private enum vJoyAxis : uint
		{
			None = 0,
			Axis_X,
			Axis_X_Reverse,
			Axis_Y,
			Axis_Y_Reverse,
			Axis_Z,
			Axis_Z_Reverse,
			Axis_RX,
			Axis_RX_Reverse,
			Axis_RY,
			Axis_RY_Reverse,
			Axis_RZ,
			Axis_RZ_Reverse,
			Axis_SL0,
			Axis_SL0_Reverse,
			Axis_SL1,
			Axis_SL1_Reverse,
		}

		private const int WM_INPUT = 0x00FF;

		private const int VJOY_ID = 1;
		private const int VJOY_AXIS_MIN = 0x0;
		private const int VJOY_AXIS_MAX = 0x8000;
		private const int VJOY_AXIS_CENTER = 0x4000;

		// ----------------------------------------------------------------------------------------
		private bool IsEnable { get { return CheckBox_Enable.Checked; } }

		private vJoyButton InputButtonPlusX { get { return (vJoyButton)ComboBox_X_Plus_Button.SelectedItem; } }
		private vJoyButton InputButtonMinusX { get { return (vJoyButton)ComboBox_X_Minus_Button.SelectedItem; } }
		private vJoyAxis InputAxisX { get { return (vJoyAxis)ComboBox_X_Axis.SelectedItem; } }

		private vJoyButton InputButtonPlusY { get { return (vJoyButton)ComboBox_Y_Plus_Button.SelectedItem; } }
		private vJoyButton InputButtonMinusY { get { return (vJoyButton)ComboBox_Y_Minus_Button.SelectedItem; } }
		private vJoyAxis InputAxisY { get { return (vJoyAxis)ComboBox_Y_Axis.SelectedItem; } }

		private float MoveStopTime { get { return (float)NumBox_MouseStopTime.Value; } }
		private int MoveDeadZone { get { return (int)NumBox_MouseDeadZone.Value; } }

		// ----------------------------------------------------------------------------------------
#if DEBUG
		[System.Runtime.InteropServices.DllImport("kernel32.dll")]
		private static extern bool AllocConsole();
#endif

		// ----------------------------------------------------------------------------------------
		#region Windows Form Life Cycle

		public MainForm()
		{
			InitializeComponent();

			InitializeNotifyIcon();
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);

#if DEBUG
			AllocConsole();
			Console.WriteLine("Debug Mode: Console opened.");
#endif
			InitializeVirtualDevice();

			InitializeMouseInput();

			InitializeUI();

			ResetMouseInput();
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			FinalizeUI();

			FinalizeMouseInput();

			FinalizeVirtualDevice();

			FinalizeNotifyIcon();

			base.OnFormClosing(e);
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == WM_INPUT)
			{
				if (IsEnable)
				{
					RawMouseInput.ProcessRawInputMessage(m.LParam, MoveDeadZone, OnMouseMoveDetected);
				}
			}

			base.WndProc(ref m);
		}

		#endregion

		// ----------------------------------------------------------------------------------------
		#region Error Handle
		private bool m_isErrorExit = false;

		private void ShowErrorDialogAndExitApp(string errorMsg)
		{
			DialogResult result = MessageBox.Show(
				errorMsg,
				Application.ProductName,
				MessageBoxButtons.OK,
				MessageBoxIcon.Error
			);

			if (result == DialogResult.OK)
			{
				m_isErrorExit = true;
				Application.Exit();
			}
		}

		#endregion

		// ----------------------------------------------------------------------------------------
		#region Notify Icon

		private NotifyIcon m_notifyIcon;
		private ContextMenuStrip m_notifyIconContextMenu;

		private void InitializeNotifyIcon()
		{
			m_notifyIcon = new NotifyIcon();
			m_notifyIcon.Icon = Properties.Resource.Icon;
			m_notifyIcon.Text = Application.ProductName;
			m_notifyIcon.Visible = true;

			m_notifyIconContextMenu = new ContextMenuStrip();
			var openMenuItem = new ToolStripMenuItem("Open", null, NotifyIcon_ContextMenu_Open_Clicked);
			m_notifyIconContextMenu.Items.Add(openMenuItem);
			m_notifyIcon.ContextMenuStrip = m_notifyIconContextMenu;

			m_notifyIcon.MouseClick += NotifyIcon_Clicked;

			this.Resize += MainForm_Resized;
		}

		private void FinalizeNotifyIcon()
		{
			m_notifyIcon.Visible = false;
			m_notifyIcon = null;
		}

		private void ShowApp()
		{
			this.Show();
			this.WindowState = FormWindowState.Normal;
			this.TopMost = true;
			this.TopMost = false;
		}

		private void MainForm_Resized(object sender, EventArgs e)
		{
			if (this.WindowState == FormWindowState.Minimized)
			{
				this.Hide();
			}
		}

		private void NotifyIcon_Clicked(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ShowApp();
			}
		}

		private void NotifyIcon_ContextMenu_Open_Clicked(object sender, EventArgs e)
		{
			ShowApp();
		}

		#endregion

		// ----------------------------------------------------------------------------------------
		#region UI

		private void InitializeUI()
		{
			this.Text = Application.ProductName;

			Label_App_Version.Text = "ver " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

			CheckBox_Enable.Checked = Properties.Settings.Default.Enable;

			ComboBox_X_Plus_Button.DataSource = Enum.GetValues<vJoyButton>();
			ComboBox_X_Plus_Button.SelectedItem = (vJoyButton)Properties.Settings.Default.InputXPlusButton;

			ComboBox_X_Minus_Button.DataSource = Enum.GetValues<vJoyButton>();
			ComboBox_X_Minus_Button.SelectedItem = (vJoyButton)Properties.Settings.Default.InputXMinusButton;

			ComboBox_X_Axis.DataSource = Enum.GetValues<vJoyAxis>();
			ComboBox_X_Axis.SelectedItem = (vJoyButton)Properties.Settings.Default.InputXAxis;

			ComboBox_Y_Plus_Button.DataSource = Enum.GetValues<vJoyButton>();
			ComboBox_Y_Plus_Button.SelectedItem = (vJoyButton)Properties.Settings.Default.InputYPlusButton;

			ComboBox_Y_Minus_Button.DataSource = Enum.GetValues<vJoyButton>();
			ComboBox_Y_Minus_Button.SelectedItem = (vJoyButton)Properties.Settings.Default.InputYMinusButton;

			ComboBox_Y_Axis.DataSource = Enum.GetValues<vJoyAxis>();
			ComboBox_Y_Axis.SelectedItem = (vJoyButton)Properties.Settings.Default.InputYAxis;

			NumBox_MouseStopTime.Value = (decimal)Properties.Settings.Default.MoveStopTime;
			NumBox_MouseDeadZone.Value = Properties.Settings.Default.MoveDeadZone;

			SetPicBoxColorButton(PicBox_X_Plus_Button, false);
			SetPicBoxColorButton(PicBox_X_Minus_Button, false);
			SetPicBoxColorAxis(PicBox_X_Axis, 0);

			SetPicBoxColorButton(PicBox_Y_Plus_Button, false);
			SetPicBoxColorButton(PicBox_Y_Minus_Button, false);
			SetPicBoxColorAxis(PicBox_Y_Axis, 0);
		}

		private void FinalizeUI()
		{
			if (m_isErrorExit)
			{
				return;
			}

			Properties.Settings.Default.Enable = CheckBox_Enable.Checked;

			Properties.Settings.Default.InputXPlusButton = (uint)(vJoyButton)ComboBox_X_Plus_Button.SelectedItem;
			Properties.Settings.Default.InputXMinusButton = (uint)(vJoyButton)ComboBox_X_Minus_Button.SelectedItem;
			Properties.Settings.Default.InputXAxis = (uint)(vJoyAxis)ComboBox_X_Axis.SelectedItem;

			Properties.Settings.Default.InputYPlusButton = (uint)(vJoyButton)ComboBox_Y_Plus_Button.SelectedItem;
			Properties.Settings.Default.InputYMinusButton = (uint)(vJoyButton)ComboBox_Y_Minus_Button.SelectedItem;
			Properties.Settings.Default.InputYAxis = (uint)(vJoyAxis)ComboBox_Y_Axis.SelectedItem;

			Properties.Settings.Default.MoveStopTime = (float)NumBox_MouseStopTime.Value;
			Properties.Settings.Default.MoveDeadZone = (int)NumBox_MouseDeadZone.Value;

			Properties.Settings.Default.Save();
		}

		private void SetPicBoxColorButton(PictureBox picBox, bool isEnable)
		{
			picBox.BackColor = isEnable ? Color.LightGreen : Color.DarkSlateGray;
		}

		private void SetPicBoxColorAxis(PictureBox picBox, int delta)
		{
			picBox.BackColor = delta > 0 ? Color.LightGreen : delta < 0 ? Color.LightBlue : Color.DarkSlateGray;
		}

		private void ComboBox_Input_SelectedIndexChanged(object sender, EventArgs e)
		{
			ResetMouseInput();
		}

		#endregion

		// ----------------------------------------------------------------------------------------
		#region Mouse Input

		private Stopwatch m_mouseStopWatch = null;
		private Timer m_mouseTimer = null;

		private void InitializeMouseInput()
		{
			RawInputHandler.RegisterMouseDevice(this.Handle);

			m_mouseStopWatch = new Stopwatch();

			m_mouseTimer = new Timer();
			m_mouseTimer.Interval = 1000 / 60;
			m_mouseTimer.Tick += CheckMouseIdle;
			m_mouseTimer.Start();
		}

		private void FinalizeMouseInput()
		{
			if (m_isErrorExit)
			{
				return;
			}

			m_mouseTimer.Stop();
			m_mouseTimer = null;

			m_mouseStopWatch = null;
		}

		private void CheckMouseIdle(object sender, EventArgs e)
		{
			if (m_mouseStopWatch.IsRunning &&
				m_mouseStopWatch.Elapsed.TotalSeconds >= MoveStopTime)
			{
				OnMouseStopDetected();
			}
		}

		private void OnMouseMoveDetected(int deltaX, int deltaY)
		{
			bool resultPlusX = InputButtonPlusX != vJoyButton.None ? deltaX > 0 : false;
			bool resultMinusX = InputButtonMinusX != vJoyButton.None ? deltaX < 0 : false;
			int resultDeltaX = InputAxisX != vJoyAxis.None ? deltaX : 0;

			bool resultPlusY = InputButtonPlusY != vJoyButton.None ? deltaY > 0 : false;
			bool resultMinusY = InputButtonMinusY != vJoyButton.None ? deltaY < 0 : false;
			int resultDeltaY = InputAxisY != vJoyAxis.None ? deltaY : 0;

			if (IsValidVJoy())
			{
				InputVirtualDeviceButton(InputButtonPlusX, resultPlusX);
				InputVirtualDeviceButton(InputButtonMinusX, resultMinusX);
				InputVirtualDeviceAxis(InputAxisX, resultDeltaX);

				InputVirtualDeviceButton(InputButtonPlusY, resultPlusY);
				InputVirtualDeviceButton(InputButtonMinusY, resultMinusY);
				InputVirtualDeviceAxis(InputAxisY, resultDeltaY);
			}

			SetPicBoxColorButton(PicBox_X_Plus_Button, resultPlusX);
			SetPicBoxColorButton(PicBox_X_Minus_Button, resultMinusX);
			SetPicBoxColorAxis(PicBox_X_Axis, resultDeltaX);

			SetPicBoxColorButton(PicBox_Y_Plus_Button, resultPlusY);
			SetPicBoxColorButton(PicBox_Y_Minus_Button, resultMinusY);
			SetPicBoxColorAxis(PicBox_Y_Axis, resultDeltaY);

			m_mouseStopWatch.Restart();
		}

		private void OnMouseStopDetected()
		{
			m_mouseStopWatch.Stop();

			if (IsValidVJoy())
			{
				InputVirtualDeviceButton(InputButtonPlusX, false);
				InputVirtualDeviceButton(InputButtonMinusX, false);
				InputVirtualDeviceAxis(InputAxisX, 0);

				InputVirtualDeviceButton(InputButtonPlusY, false);
				InputVirtualDeviceButton(InputButtonMinusY, false);
				InputVirtualDeviceAxis(InputAxisY, 0);
			}

			SetPicBoxColorButton(PicBox_X_Plus_Button, false);
			SetPicBoxColorButton(PicBox_X_Minus_Button, false);
			SetPicBoxColorAxis(PicBox_X_Axis, 0);

			SetPicBoxColorButton(PicBox_Y_Plus_Button, false);
			SetPicBoxColorButton(PicBox_Y_Minus_Button, false);
			SetPicBoxColorAxis(PicBox_Y_Axis, 0);
		}

		private void ResetMouseInput()
		{
			m_mouseStopWatch.Stop();

			if (IsValidVJoy())
			{
				ReleaseVirtualDeviceAllInputs();
			}

			SetPicBoxColorButton(PicBox_X_Plus_Button, false);
			SetPicBoxColorButton(PicBox_X_Minus_Button, false);
			SetPicBoxColorAxis(PicBox_X_Axis, 0);

			SetPicBoxColorButton(PicBox_Y_Plus_Button, false);
			SetPicBoxColorButton(PicBox_Y_Minus_Button, false);
			SetPicBoxColorAxis(PicBox_Y_Axis, 0);
		}

		#endregion

		// ----------------------------------------------------------------------------------------
		#region Virtual Game Pad

		private vJoy m_vJoy = null;

		private bool IsValidVJoy()
		{
			return m_vJoy != null && m_vJoy.isVJDExists(VJOY_ID);
		}

		private void InitializeVirtualDevice()
		{
			m_vJoy = new vJoy();

			if (m_vJoy.vJoyEnabled())
			{
				if (m_vJoy.AcquireVJD(VJOY_ID))
				{
#if DEBUG
					Console.WriteLine("Virtual device successfully activated.");
#endif
				}
				else
				{
					ShowErrorDialogAndExitApp("Failed to activate virtual device.");
				}
			}
			else
			{
				ShowErrorDialogAndExitApp("vJoy is not enabled.");
			}
		}

		private void FinalizeVirtualDevice()
		{
			if (m_vJoy.isVJDExists(VJOY_ID))
			{
				m_vJoy.RelinquishVJD(VJOY_ID);
#if DEBUG
				Console.WriteLine("Virtual device has been released.");
#endif
			}

			m_vJoy = null;
		}

		private void InputVirtualDeviceButton(vJoyButton input, bool press)
		{
			if (input != vJoyButton.None)
			{
				m_vJoy.SetBtn(press, VJOY_ID, (uint)input);
#if DEBUG
				Console.WriteLine(press ? $"{input} Pressed." : $"{input} Released.");
#endif
			}
		}

		private void InputVirtualDeviceAxis(vJoyAxis input, int delta)
		{
			if (input != vJoyAxis.None)
			{
				HID_USAGES axis = HID_USAGES.HID_USAGE_X;
				int value = VJOY_AXIS_CENTER;

				switch (input)
				{
					case vJoyAxis.Axis_X:
					case vJoyAxis.Axis_X_Reverse:
						axis = HID_USAGES.HID_USAGE_X;
						break;
					case vJoyAxis.Axis_Y:
					case vJoyAxis.Axis_Y_Reverse:
						axis = HID_USAGES.HID_USAGE_Y;
						break;
					case vJoyAxis.Axis_Z:
					case vJoyAxis.Axis_Z_Reverse:
						axis = HID_USAGES.HID_USAGE_Z;
						break;
					case vJoyAxis.Axis_RX:
					case vJoyAxis.Axis_RX_Reverse:
						axis = HID_USAGES.HID_USAGE_RX;
						break;
					case vJoyAxis.Axis_RY:
					case vJoyAxis.Axis_RY_Reverse:
						axis = HID_USAGES.HID_USAGE_RY;
						break;
					case vJoyAxis.Axis_RZ:
					case vJoyAxis.Axis_RZ_Reverse:
						axis = HID_USAGES.HID_USAGE_RZ;
						break;
					case vJoyAxis.Axis_SL0:
					case vJoyAxis.Axis_SL0_Reverse:
						axis = HID_USAGES.HID_USAGE_SL0;
						break;
					case vJoyAxis.Axis_SL1:
					case vJoyAxis.Axis_SL1_Reverse:
						axis = HID_USAGES.HID_USAGE_SL1;
						break;
					default:
						break;
				}

				if ((int)input % 2 != 0)
				{
					value = delta == 0 ? VJOY_AXIS_CENTER : delta > 0 ? VJOY_AXIS_MAX : VJOY_AXIS_MIN;
				}
				else
				{
					value = delta == 0 ? VJOY_AXIS_CENTER : delta > 0 ? VJOY_AXIS_MIN : VJOY_AXIS_MAX;
				}

				if (m_vJoy.GetVJDAxisExist(VJOY_ID, axis))
				{
					m_vJoy.SetAxis(value, VJOY_ID, axis);
#if DEBUG
					Console.WriteLine($"{input} Set delta:{delta} value:{value}.");
#endif
				}
			}
		}

		private void ReleaseVirtualDeviceAllInputs()
		{
			m_vJoy.ResetButtons(VJOY_ID);

			Array axes = Enum.GetValues(typeof(HID_USAGES));
			for (int i = 0; i < axes.Length; i++)
			{
				HID_USAGES axis = (HID_USAGES)axes.GetValue(i);
				if (m_vJoy.GetVJDAxisExist(VJOY_ID, axis))
				{
					m_vJoy.SetAxis(VJOY_AXIS_CENTER, VJOY_ID, axis);
				}
			}

#if DEBUG
			Console.WriteLine($"All buttons and axes have been released.");
#endif
		}

		#endregion
	}
}
