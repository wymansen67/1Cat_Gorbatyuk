﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cat
    {
        public Cat(string CatName)
        {
            Name = CatName;
        }

        private string name;
        public string nameP;
        private double weight;

        public string Name
        {
            get { return name; }
            set
            {
                bool OnlyLetters = true;
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }
        }

        public string Weight
        {
            get { return weight.ToString(); }
            set
            {
                bool valid = true;
                if (value.Contains(".")) valid = false;
                else if (double.Parse(value) <= 0) valid = false;                
                if (valid)
                {
                    foreach (var ch in value)
                    {
                        if (!char.IsDigit(ch) && ch != ',') { valid = false; break; }
                    }
                }
                if (valid)
                {
                    weight = double.Parse(value);
                }
                else
                {
                    Console.WriteLine($"{value} - недопустимое значение веса!");
                }
            }
        }

        public void Meow()
        {
            Console.Write($"{name}: МЯУ!");
        }

        public void Fat()
        {
            Console.WriteLine($" Вес: {weight}");
        }

        /*public void SetCatName(string CatName)
        {

            bool OnlyLetters = true;

            foreach (var ch in CatName)
            {
                if (!char.IsLetter(ch)) { OnlyLetters = false; break; }
            }

            if (OnlyLetters) name = CatName;
            else Console.WriteLine($"{CatName} - неправильное имя!!!");
        }*/

    }
}
