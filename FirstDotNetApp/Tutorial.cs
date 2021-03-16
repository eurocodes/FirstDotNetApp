using System;
using System.Collections.Generic;
using System.Text;

namespace FirstDotNetApp
{
    class Tutorial
    {
        int TutorialID;
        string TutorialName;

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
