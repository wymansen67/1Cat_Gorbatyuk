using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {                        
            Cat murzik = new Cat("Мурзик");
            Cat barsik = new Cat("Барсук");
            Cat barsik123 = new Cat("Барсик123");
            murzik.Meow();
            murzik.Weight = "12,5";
            murzik.Fat();
            barsik.Meow();
            barsik.Fat();
            barsik.Name = "Барсик";
            barsik.Weight = "12,5";
            barsik.Meow();
            barsik.Fat();
            murzik.Name = "12421";
            murzik.Weight = "-9,7";
            murzik.Meow();
            murzik.Fat();
            /*Console.WriteLine("Введите вес барсика");
            barsik.Weight = Console.ReadLine();
            Console.WriteLine(barsik.Weight);*/
            Console.ReadKey();
        }
    }
}
