using System;

namespace DelegateTest
{
    delegate void MyDelegate1();
    delegate void MyDelegate2(int n);

    public class DelClass
    {
        public void Tunnel()
        {
            Console.WriteLine("�ͳ��� �������ϴ�.");
        }
    }
    class DelTest3
    {
        public static void TunnelOut(int i)
        {
            Console.WriteLine("{0}���� �¿����� �ͳ��� ���������ϴ�.", i);
        }
        public static void Main()
        {

            DelClass dc = new DelClass();
            MyDelegate1 myDel1 = new MyDelegate1(dc.Tunnel);
            MyDelegate2 myDel2 = new MyDelegate2(TunnelOut);
            myDel1();
            myDel2(34);
        }
    }
}