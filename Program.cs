using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework___8
{
    class Program
    {
        static void Main(string[] args)
        {
            string Hello = Properties.Settings.Default.Hello;
            Console.Write($"{Hello}, ");

            if (string.IsNullOrEmpty(Properties.Settings.Default.Name))
            {
                Console.Write("Введите своё имя: ");
                Properties.Settings.Default.Name = Console.ReadLine();
                Properties.Settings.Default.Save();
            }

            if (string.IsNullOrEmpty(Properties.Settings.Default.Profession))
            {
                Console.Write("Введите свою профессию: ");
                Properties.Settings.Default.Profession = Console.ReadLine();
                Properties.Settings.Default.Save();
            }

            if (string.IsNullOrEmpty(Properties.Settings.Default.Age))
            {
                Console.Write("Введите свой возраст: ");
                Properties.Settings.Default.Age = Console.ReadLine();
                Properties.Settings.Default.Save();
            }

            string Name = Properties.Settings.Default.Name;
            string Profession = Properties.Settings.Default.Profession;
            string Age = Properties.Settings.Default.Age;
            Console.WriteLine($"{Name}, {Age}, {Profession}");

            Console.ReadKey();
        }
    }
}
