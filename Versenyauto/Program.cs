using System;

namespace Versenyauto
{
    public class Program
    {
        static void Main(string[] args)
        {
            Kocsi kocsi = new Kocsi("Suzuki", "Swift", 1993, 0);
            Console.WriteLine(kocsi);
        }
    }
}