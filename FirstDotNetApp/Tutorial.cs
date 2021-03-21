using System;
using System.Collections.Generic;
using System.Text;

namespace FirstDotNetApp
{
    class Tutorial // this is the base class (ie, parent to Guru99Tutorial class...
    {
        protected int TutorialID;
        protected string TutorialName;
        
        public Tutorial() // Method, class constructor for the Tutorial class...
        {
            TutorialID = 0;
            TutorialName = "Default";
        }
        public void SetTutorial(int pID, string pName)
        {
            TutorialID = pID;
            TutorialName = pName;
        }
        public void SetTutorial(string pName)
        {
            TutorialName = pName;
        }

        public string GetTutorial()
        {
            return TutorialID +": "+ TutorialName;
        }

    }
    class Guru99Tutorial : Tutorial
    {
        public void RenameTutorial(int pNewId, string pNewName)
        {
            TutorialID = pNewId;
            TutorialName = pNewName;
        }
    }
}
