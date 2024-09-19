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
            //3.feladat:
            Console.WriteLine("3.feladat:");
            foreach (var item in eredmenylista)
            {
                Console.WriteLine(item.name);
            }
            Console.WriteLine();
            //4.feladat:
            Console.WriteLine("4.feladat:");
            int szam = 0;
            int id = 0;
            foreach (var item in eredmenylista)
            {
                if (szam<item.kereset)
                {
                    szam = item.kereset;
                    id = item.id;
                }
            }
            foreach (var item in eredmenylista)
            {
                if(item.id==id)
                {
                    Console.WriteLine($"{item.id} {item.name}");
                }
            }                            
            Console.WriteLine();
            //5.feladat:
            Console.WriteLine("5.feladat:");
            foreach (var item in eredmenylista)
            {
                if (item.age == 55)
                {
                    Console.WriteLine($"{item.name} {item.age}");
                }
            }
            Console.WriteLine();
            //6.feladat:
            Console.WriteLine("6.feladat:");
            int ossz = 0;
            foreach (var item in eredmenylista)
            {
                if (item.kereset > 50000)
                {
                    ossz++;
                }
            }
            Console.WriteLine($"{ossz} keresnek 50000ft felett!");
            Console.ReadLine();
        }
    }
}
