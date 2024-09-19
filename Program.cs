using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_19_Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<tulajdonsag> eredmenylista = new List<tulajdonsag>();
            StreamReader sr = new StreamReader("tulajdonsagok_100sor.txt");
            while (!sr.EndOfStream)
            {
                eredmenylista.Add(new tulajdonsag(sr.ReadLine()));
            }
            sr.Close();
            Console.ReadLine();
        }
    }
}
