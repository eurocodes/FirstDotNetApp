using System;

namespace FirstDotNetApp
{
    class Program
    {
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday}
        static void Main(string[] args)
        {
            String message = "Press any key to continue";
            Int32[] values;
            values = new Int32[3];

            values[0] = 1;
            values[1] = 2;
            values[2] = 3;

            Console.WriteLine(values[0]);
            Console.WriteLine(values[1]);
            Console.WriteLine(values[2]);

            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
