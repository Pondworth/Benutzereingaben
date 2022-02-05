using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benutzereingaben
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gebe bitte deinen Namen ein: ");
            string name = Console.ReadLine();

            Console.Write("Gebe dein Alter ein: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hallo {0}, Du bist also {1} Jahre alt!", name, age);
            //Console.WriteLine("Hallo " + name + " du bist also " + age + "Jahre alt");

            //Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
