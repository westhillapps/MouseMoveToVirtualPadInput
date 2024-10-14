using System;
using System.Runtime.InteropServices;

namespace MouseMoveToVirtualPadInput
{
	// ----------------------------------------------------------------------------------------
	public static class RawInputHandler
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct RawInputDevice
        {
            public ushort UsagePage;
            public ushort Usage;
            public uint Flags;
            public IntPtr Target;
        }

        const int HID_USAGE_PAGE_GENERIC = 0x01;
        const int HID_USAGE_GENERIC_MOUSE = 0x02;
		const int RIDEV_INPUTSINK = 0x00000100;

		[DllImport("User32.dll", SetLastError = true)]
        private static extern bool RegisterRawInputDevices(RawInputDevice[] pRawInputDevice, uint uiNumDevices, uint cbSize);

        public static void RegisterMouseDevice(IntPtr hwnd)
        {
            RawInputDevice[] rid = new RawInputDevice[1];

            rid[0].UsagePage = HID_USAGE_PAGE_GENERIC;
            rid[0].Usage = HID_USAGE_GENERIC_MOUSE;
            rid[0].Flags = RIDEV_INPUTSINK;
            rid[0].Target = hwnd;

            if (!RegisterRawInputDevices(rid, (uint)rid.Length, (uint)Marshal.SizeOf(rid[0])))
            {
                throw new Exception("Failed to register Raw Input device.");
            }
        }
    }

	// ----------------------------------------------------------------------------------------
	public static class RawMouseInput
    {
        [StructLayout(LayoutKind.Sequential)]
        struct RawInputHeader
        {
            public uint Type;
            public uint Size;
            public IntPtr Device;
            public IntPtr wParam;
        }

        [StructLayout(LayoutKind.Sequential)]
		struct RawMouse
        {
            public ushort Flags;
			public ushort ButtonFlags;
            public ushort ButtonData;
            public uint RawButtons;
            public int LastX;
            public int LastY;
            public uint ExtraInformation;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct RawInput
        {
            public RawInputHeader Header;
            public RawMouse Mouse;
        }

		[Flags()]
		enum RawMouseButtons : ushort
		{
			None = 0,
			LeftDown = 0x0001,
			LeftUp = 0x0002,
			RightDown = 0x0004,
			RightUp = 0x0008,
			MiddleDown = 0x0010,
			MiddleUp = 0x0020,
			Button4Down = 0x0040,
			Button4Up = 0x0080,
			Button5Down = 0x0100,
			Button5Up = 0x0200,
			MouseWheel = 0x0400
		}

		const int RID_INPUT = 0x10000003;
		const int RIM_TYPEMOUSE = 0;

		[DllImport("User32.dll")]
        extern static uint GetRawInputData(IntPtr hRawInput, uint uiCommand, IntPtr pData, ref uint pcbSize, uint cbSizeHeader);

		public static void ProcessRawInputMessage(IntPtr lParam, int moveDeadZone, Action<int, int> onMouseMoveDetected)
        {
            uint dwSize = 0;
            GetRawInputData(lParam, RID_INPUT, IntPtr.Zero, ref dwSize, (uint)Marshal.SizeOf(typeof(RawInputHeader)));

            IntPtr buffer = Marshal.AllocHGlobal((int)dwSize);
            try
            {
                if (GetRawInputData(lParam, RID_INPUT, buffer, ref dwSize, (uint)Marshal.SizeOf(typeof(RawInputHeader))) != dwSize)
                {
#if DEBUG
					Console.WriteLine("GetRawInputData does not return correct size!");
#endif
                    return;
                }

                RawInput raw = (RawInput)Marshal.PtrToStructure(buffer, typeof(RawInput));

                if (raw.Header.Type == RIM_TYPEMOUSE)
                {
                    int deltaX = raw.Mouse.LastX;
                    int deltaY = raw.Mouse.LastY;

                    if (Math.Abs(deltaX) <= moveDeadZone)
                    {
                        deltaX = 0;
                    }

					if (Math.Abs(deltaY) <= moveDeadZone)
					{
						deltaY = 0;
					}

                    if (deltaX != 0 || deltaY != 0)
                    {
						onMouseMoveDetected?.Invoke(deltaX, deltaY);
					}
				}
			}
            finally
            {
                Marshal.FreeHGlobal(buffer);
            }
        }
    }
}
