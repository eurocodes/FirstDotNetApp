using System;

namespace FirstDotNetApp
{
    class Program
    {
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday}
        static void Main(string[] args)
        {
            Int32 num = 150, value = 4, i = 0;
            String message = "Press any key to continue";

            Console.WriteLine(Days.Sunday);
            Console.WriteLine(num);

            // If statement
            if(value < 10)
            {
                Console.WriteLine("Value is less than 10");
            } else
            {
                Console.WriteLine("Value is greater than 10");
            }

            // Switch statement
            switch (value)
            {
                case 1: Console.WriteLine("Value is 1");
                    break;
                case 2: Console.WriteLine("Vakue is 2");
                    break;
                default: Console.WriteLine("Value is different");
                    break;
            }

            //While loop
            while (i < value)
            {
                Console.WriteLine(i);
                i = i + 1;
            }

            //For loop
            for(Int32 j = 0; j<3; j++)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
