using System;
using System.Collections;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList ProgrammingLanguage = new SortedList();

            ProgrammingLanguage.Add(1964, "Basic");
            ProgrammingLanguage.Add(1966, "JOSS");
            ProgrammingLanguage.Add(1962, "APL");
            ProgrammingLanguage.Add(2001, "C#");
            ProgrammingLanguage.Add(1966, "MUMPS");
            ProgrammingLanguage.Add(1954, "IPL");

            Console.WriteLine("Illere gore: ");

            foreach (var item in ProgrammingLanguage)
            {
                Console.WriteLine(item.key + " " + item.value);
            }

            SortedList ProgrammingLanguage1 = new SortedList();

            ProgrammingLanguage.Add("Basic", 1964);
            ProgrammingLanguage.Add("JOSS", 1966);
            ProgrammingLanguage.Add("APL", 1962);
            ProgrammingLanguage.Add("C#", 2001);
            ProgrammingLanguage.Add("MUMPS", 1966);
            ProgrammingLanguage.Add("IPL", 1954);

            Console.WriteLine("Adlara gore: ");

            foreach (var item in ProgrammingLanguage)
            {
                Console.WriteLine(item.key + " " + item.value);
            }
        }
    }
}
