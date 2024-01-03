using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceproject2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader studentdata;
            try
            {
                string fpath = @"C:\Users\user\Desktop\mphasis\studentdata.txt";
                Console.WriteLine("**Student Data :**");
                studentdata = new StreamReader(fpath);
                string Textfile = "";
                while ((Textfile = studentdata.ReadLine()) != null)
                {
                    Console.WriteLine(Textfile);
                }
                studentdata.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
