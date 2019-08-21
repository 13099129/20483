using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class TeacherUtils
    {

        public bool IsWorkday(out string dayname)
        {

            dayname = DateTime.Now.DayOfWeek.ToString();
            return true;
        }


        public string GetGrade(float score,  float curve)
        {
            if (curve < 0)
            {
                throw new ApplicationException("Curve Parameter should not be negative.");
            }
            string result = "";
            if (score + curve >= 90f)
            {
                result = "A";
            }
            else if (score + curve >= 80f)
            {
                result = "B";
            }
            else
            {
                result = "C";
            }
            curve = 0;
            return result;
        }

        public string GetGrade(float testscore)
        {
            string result = "A";
            if (testscore >= 90f)
            {
                result = "A";
            }
            else if (testscore >= 80f)
            {
                result = "B";
            }
            else
            {
                result = "C";
            }
            return result;
        }


    }
}
