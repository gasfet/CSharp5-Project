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
      Console.Write("�޽��� �Է�(����) : ");
      myString = Console.ReadLine();
      Console.Write("0~6 �Է�(����) : ");
      myint = Convert.ToInt32(Console.Read());
      return MessageBox(0, myString, "�޽��� â", myint);
   }
}