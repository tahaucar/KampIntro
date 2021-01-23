using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> { "Engin", "Zeynel", "Taha", "Kerem" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler[4]="Ali";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[1]);
        }
    }
}
