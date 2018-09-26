using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    abstract class Tutorial
    {
        public virtual void Set()
        {

        }
    }
    class Abstract3 : Tutorial
    {
        protected int TutorialID;
        protected string TutorialName;
        public void SetTutorial(int pID, string pName)
        {
            TutorialID = pID;
            TutorialName = pName;
        }
        public String GetTutorialName()
        {
             return TutorialName;
        }
        public int GetTutorialId()
        {
            return TutorialID;
        }
        static void Main(string[] args)
        {
            Abstract3 pTutor = new Abstract3();
            pTutor.SetTutorial(1,".Net");
            Console.WriteLine(pTutor.GetTutorialId()+" : "+pTutor.GetTutorialName());
        }
    }
}
