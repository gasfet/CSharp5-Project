using System;

class DelTest1
{
    delegate void MyDel(string s);

    static void Main(string[] args)
    {
        MyDel myDel = new MyDel(ExamMethod);
        myDel("Hello C#");
    }

    public static void ExamMethod(string s)
    {
        Console.WriteLine(s);
    }
}