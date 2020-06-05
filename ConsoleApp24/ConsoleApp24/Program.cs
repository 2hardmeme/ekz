using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"input.txt";
            Shoes[] shoes = ReadData(path);
            runMenu(shoes);
            Console.Read();
        }
        static Shoes[] ReadData(string fileName)
        {
            string[] pathForFile = File.ReadAllLines(fileName);
            Shoes[] ArrayOfShoes = new Shoes[pathForFile.Length];
            for (int i = 0; i < pathForFile.Length; i++)
            {
                ArrayOfShoes[i] = new Shoes(pathForFile[i]);
            }
            return ArrayOfShoes;
        }
        static void runMenu(Shoes[] shoes)
        {
            Console.WriteLine("Асортимент дитячого взуття: ");
            Console.WriteLine();
            for (int i = 0; i < shoes.Length; i++)
            {
                if (shoes[i].article == "P3" || shoes[i].article == "P8" || shoes[i].article == "P9")
                {
                    Console.WriteLine("{0} {1} {2}", shoes[i].name, shoes[i].value, shoes[i].kilk);
                }
            }
            Console.WriteLine();
            //-----------------------------------------------------------
            Console.WriteLine("Середня цiна чол. взуття: ");
            Console.WriteLine();
            for (int i = 0; i < shoes.Length; i++)
            {
                if (shoes[i].article == "M2" || shoes[i].article == "M4" || shoes[i].article == "M5")
                {
                    double m = 0;
                    double n = 0;
                    m += (shoes[i].value);
                    n += (shoes[i].kilk);

                    double averageValue = (n / m);
                    Console.WriteLine(averageValue);
                }
            }
            //-----------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("Введiть артикул взуття:");
            string poshuk = Console.ReadLine();
            if (poshuk.Contains("D1"))
            {
                for (int i = 0; i < shoes.Length; i++)
                {
                    if (shoes[i].article == "D1")
                    {
                        Console.WriteLine("наявно, {0} {1}", shoes[i].name, shoes[i].kilk);
                    }
                }
            }
            else if (poshuk.Contains("D6"))
            {
                for (int i = 0; i < shoes.Length; i++)
                {
                    if (shoes[i].article == "D6")
                    {
                        Console.WriteLine("наявно, {0} {1}", shoes[i].name, shoes[i].kilk);
                    }
                }
            }
            else if (poshuk.Contains("D7"))
            {
                for (int i = 0; i < shoes.Length; i++)
                {
                    if (shoes[i].article == "D7")
                    {
                        Console.WriteLine("наявно, {0} {1}", shoes[i].name, shoes[i].kilk);
                    }
                }
            }
            else
                Console.WriteLine("немає в наявносi");
        }
    }
}