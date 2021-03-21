using System;

namespace FirstDotNetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String message = "Press any key to continue";

            Tutorial initTutor = new Tutorial();
            Console.WriteLine(initTutor.GetTutorial());

            Guru99Tutorial pTutor = new Guru99Tutorial();
            pTutor.RenameTutorial(1,".Net by Guru99");
            Console.WriteLine(pTutor.GetTutorial());

            initTutor.SetTutorial(2, "Newform Tutorial");
            Console.WriteLine(initTutor.GetTutorial());

            initTutor.SetTutorial("Newform Tutorial, Name only");
            Console.WriteLine(initTutor.GetTutorial());

            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
