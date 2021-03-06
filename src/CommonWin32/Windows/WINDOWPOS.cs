using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.ComponentModel;
using CommonWin32.Rectangles;

namespace CommonWin32.Windows
{
	/// <summary>
	/// Contains information about the size and position of a window.
	/// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct WINDOWPOS
    {
        /// <summary>
        /// Handle to the window.
        /// </summary>
        public IntPtr hwnd;
        /// <summary>
        /// Specifies the position of the window in Z order (front-to-back position). 
        /// This member can be a handle to the window behind which this window is placed, 
        /// or can be one of the special values listed with the SetWindowPos function.
        /// </summary>
        public IntPtr hWndInsertAfter;
        /// <summary>
        /// Specifies the position of the left edge of the window.
        /// </summary>
        public int x;
        /// <summary>
        /// Specifies the position of the top edge of the window.
        /// </summary>
        public int y;
        /// <summary>
        /// Specifies the window width, in pixels.
        /// </summary>
        public int cx;
        /// <summary>
        /// Specifies the window height, in pixels.
        /// </summary>
        public int cy;
        /// <summary>
        /// Specifies the window position.
        /// </summary>
        public SetWindowPosOptions flags;

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format("x={0}, y={1}, cx={2}, cy={3}, flags={4}", x, y, cx, cy, flags);
        }
    }
}
