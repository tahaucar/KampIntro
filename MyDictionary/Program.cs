using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler= new MyList<string>();
            isimler.add("ali");
            isimler.add("ayşe");
            isimler.add("ahmet");
            isimler.add("osman");
            isimler.add("fatma");
            Console.WriteLine(isimler.Count);
        }
    }
}
