using System;
 using System.Runtime.InteropServices;    

 class Class1
 {
     [DllImport("user32.dll", CharSet=CharSet.Auto)]
     static extern int MessageBox(IntPtr hWnd, String text, String caption, int options);

     [STAThread]
     static void Main(string[] args)
     {
         MessageBox(IntPtr.Zero, "Text", "Caption", 0);
     }
 }