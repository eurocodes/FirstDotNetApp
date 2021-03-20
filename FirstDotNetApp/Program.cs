using System;

namespace FirstDotNetApp
{
    class Program
    {
        enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday}
        static void Main(string[] args)
        {
            String message = "Press any key to continue";
            
            Tutorial pTutor = new Tutorial();
            Console.WriteLine(pTutor.GetTutorial());

            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
