using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_5_2_2__5_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var (username, userage) = ("Евгения", 27);

            Console.WriteLine("Введите имя: {0}", username);
            Console.WriteLine("Ваш возраст: {0}", userage);

            Console.Write("Введите имя: ");
            username = Console.ReadLine();

            Console.Write("Введите возраст цифрами: ");
            userage = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", username);
            Console.WriteLine("Ваш возраст: {0}", userage);

            var favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor(username);
            }

            Console.WriteLine("Ваши любимые цвета:");

            foreach (var item in favcolors)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static string ShowColor(string username)
        {
            Console.WriteLine("{0} Напишите свой любимый цвет на английском с маленькой буквы", username);
            string color = Console.ReadLine();
            Console.WriteLine("Your color is " + color);
            return color;
        }
    }
}
