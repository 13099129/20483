using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Demo1
{

    namespace ftp
    {

    }

    namespace data
    {
        public class Patient
        {
            public string Mrn { get; set; }
            public string Firstname{get;set;}
          

            public bool SaveData()
            {
                return true;
            }

        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            ShowLoop();

            Console.WriteLine("Enter a test score");
            string score = Console.ReadLine();
            float fscore = float.Parse(score);
            string x = GetGrade(fscore);
            Console.WriteLine($"Grade is {x}");

          //the arg is going to be a directory

            foreach(string arg in args)
            {
                //Console.WriteLine("Enumerating:" + arg);
                Console.WriteLine($"Enumerating:{arg}");
                System.IO.DirectoryInfo dirInfo;
                dirInfo = new System.IO.DirectoryInfo(arg);
                foreach(System.IO.FileInfo finfo in dirInfo.GetFiles())
                {
                    Console.WriteLine(finfo.Name);
                    Console.WriteLine(finfo.LastAccessTime);
                    Console.WriteLine(finfo.CreationTime);
                    Console.WriteLine(finfo.Length);
                    if (finfo.Name.EndsWith(".xml"))
                    {
                        finfo.CopyTo($"c:\\xmlfiles\\{finfo.Name}");
                        //finfo.Delete();
                    }

                }

            }
            
            Console.WriteLine("Press Enter to end");

            Console.ReadLine();

        }


        public static string GetGrade(float testscore)
        {
            string result;
            if (testscore > 90)
            {
                result = "A";
                //more code
            }
            else if(testscore>=80){
                result = "B";
            }
            else{
                result = "F";
            }


            return result;
        }


        public static void ShowLoop()
        {
            string[] names=new string[5];
            names[0] = "Matt";
            names[1] = "Violet";
            names[2] = "Ronan";
            names[3] = "Ash";
            names[4] = "Tevyah";

            for(Int32 i = 0; i < 5; i++)
            {
                Console.WriteLine(names[i]);
            }
            
        }

    }
}
