using System;

delegate void MyDelegate(int a);

class DelTest
{
    public static void ExamMethod1(int a) 
    { Console.WriteLine("°á°ú °ª : {0}", a); }
    public static void ExamMethod2(int b) 
    { Console.WriteLine("b + b = {0}", (b + b)); }
    public static void ExamMethod3(int c) 
    { Console.WriteLine("c * c = {0}", (c * c)); }

    static void Main()
    {
        MyDelegate MyDel;
        MyDel = new MyDelegate(ExamMethod1);
        MyDel(3);
        MyDel = new MyDelegate(ExamMethod2);
        MyDel(6);
        MyDel = new MyDelegate(ExamMethod3);
        MyDel(5);
    }
}