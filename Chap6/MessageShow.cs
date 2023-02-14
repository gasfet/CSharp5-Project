using System;
using System.Runtime.InteropServices;
class MainClass 
{
   [DllImport("User32.dll")]
   public static extern int MessageBox(int h, string m, string c, int type);
   static int Main() 
   {
      string myString; 
      int myint; 
      Console.Write("메시지 입력(엔터) : ");
      myString = Console.ReadLine();
      Console.Write("0~6 입력(엔터) : ");
      myint = Convert.ToInt32(Console.Read());
      return MessageBox(0, myString, "메시지 창", myint);
   }
}