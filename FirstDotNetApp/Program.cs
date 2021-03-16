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

            pTutor.SetTutorial(1, ".Net");
            Console.WriteLine(pTutor.GetTutorial());

            pTutor.SetTutorial(2, "C#");
            Console.WriteLine(pTutor.GetTutorial());

            pTutor.SetTutorial(3, "VB.Net");
            Console.WriteLine(pTutor.GetTutorial());

            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
