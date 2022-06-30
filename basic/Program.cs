using System;

namespace basic
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime a = DateTime.Now;            //30 / 06 / 2022 13:21:20
            Console.WriteLine(a);

            DateTime b=new DateTime(2022, 06, 30, 13, 21, 20);
            Console.WriteLine(b);
        }
    }
}
