using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Данченко1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars myCar = new Cars("Toyota", "Mark II JZX-90", 1996, 70);
            Console.WriteLine(myCar.GetCarInfo());
            
            Console.WriteLine("Привет ковбой, не хочешь прокатится?");

            while (true)
            {
                myCar.Drive();

                Console.WriteLine("Хотите заправить машину?");
                string refuelAnswer = Console.ReadLine().ToLower();

                if (refuelAnswer == "да")
                {
                    myCar.Refuel();
                }

                Console.WriteLine("Продолжить поездку?");
                string answer = Console.ReadLine().ToLower();

                if (answer != "да")
                {
                    break;
                }
            }
            Console.WriteLine("Поездка завершена");
            Console.ReadKey();
        }
    }
}
