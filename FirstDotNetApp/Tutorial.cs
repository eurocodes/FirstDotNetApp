using System;
using System.Collections.Generic;
using System.Text;

namespace FirstDotNetApp
{
    class Tutorial
    {
        int TutorialID;
        string TutorialName;
        
        public Tutorial()
        {
            TutorialID = 0;
            TutorialName = "Default";
        }
        public void SetTutorial(int pID, string pName)
        {
            TutorialID = pID;
            TutorialName = pName;
        }

        public string GetTutorial()
        {
            return TutorialID +": "+ TutorialName;
        }

    }
}
