using System;

namespace FirstDotNetApp
{
    class Program
    {
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday}
        static void Main(string[] args)
        {
            Int32 num = 150;
            double num2 = 250.50;
            Boolean status = true;
            String message = "Press any key to continue";

            Console.WriteLine(Days.Sunday);
            Console.WriteLine(num);
            Console.WriteLine(num2);
            Console.WriteLine(status);
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
