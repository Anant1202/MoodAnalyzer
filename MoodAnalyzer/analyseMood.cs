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
        //Parameterised Constructor
        public analyseMood(string message)
        {
            this.message = message;
        }

        public string AnalysingMood() 
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch
            {
                return "happy";
            }
        }
    }
}
