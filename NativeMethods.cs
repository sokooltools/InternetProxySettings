using System;
using System.Runtime.InteropServices;

namespace InternetProxySettings
{
	internal static class NativeMethods
	{
		[DllImport("wininet.dll")]
		public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);

		//------------------------------------------------------------------------------------------
		/// <summary>
		/// 
		/// </summary>
		//------------------------------------------------------------------------------------------
		internal static class MyKeyBoard
		{
			public const Int32 VK_LSHIFT = 0xa0;

			public const Int32 VK_RSHIFT = 0xa1;

			public const Int32 VK_LCONTROL = 0xa2;

			public const Int32 VK_RCONTROL = 0xa3;

			//The left Alt key.
			public const Int32 VK_LMENU = 0xa4;

			//The right Alt key.
			public const Int32 VK_RMENU = 0xa5;

			[DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
			public static extern Int32 GetKeyboardState(ref byte pbKeyState);

			[DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
			public static extern Int32 SetKeyboardState(ref byte lppbKeyState);

			[DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
			public static extern short GetKeyState(int nVirtKey);
			//# left and right Ctrl, Alt, and Shift keys, which are stored in the array at the following indices:
			//# In addition to the virtual keys, the array also sets information which distinguishes between the
			//# Each key is identified by the element corresponding with the key's virtual key code. Windows NT, 2000:

			//# lpKeyState A 256-element byte array which specifies the key status information for all virtual-keys.
		}
	}
}
