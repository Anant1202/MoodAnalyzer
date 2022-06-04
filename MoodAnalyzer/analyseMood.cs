using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class analyseMood
    {
        //public string AnalysingMood(string message)
        //{
        //    if(message=="Sad" || message=="sad")
        //    {
        //        return "Sad";
        //    }
        //    else
        //    {
        //        return message;
        //    }
        //}

        //Refactoring
        public string message;
        //Default Constructor
        public analyseMood()
        {
        }
        //Parameterised Constructor
        public analyseMood(string message)
        {
            this.message = message;
        }

        public string AnalysingMood()
        {
            if (message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
    }
}
