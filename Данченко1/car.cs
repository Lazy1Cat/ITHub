using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Данченко1
{
    public class Cars
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelLevel { get; set; }

        public Cars(string brand, string model, int year, double fuelLevel)
        {
            Brand = brand;
            Model = model;
            Year = year;
            FuelLevel = fuelLevel;
        }

        public string GetCarInfo()
        {
            return $"Марка: {Brand}, Модель: {Model}, Год: {Year}, Уровень топлива: {FuelLevel}";
        }

        public void Drive()
        {
            Console.WriteLine($"Сколько ехать хотим? (Максимум км с твоим топливом {FuelLevel * 10})");
            double distance = double.Parse(Console.ReadLine());
            
            double FuelConsumed = distance / 10;

            if (FuelLevel >= FuelConsumed)
            {
                FuelLevel -= FuelConsumed;
                Console.WriteLine($"Проехал {distance} км. Осталось топливо: {FuelLevel}");
            }
            else
            {
                Console.WriteLine("Маловато топлива для таких амбиций, может заправка это исправит?.");
            }
        }

        public void Refuel()
        {
            Console.WriteLine("Это заправка, заправить до максимума?");
            string otvet = Console.ReadLine().ToLower();
            if (otvet == "да")
            {
                if (FuelLevel < 70)
                {
                    while (FuelLevel < 70)
                    {
                        FuelLevel++;
                    }
                }
                else
                {
                    Console.WriteLine($"Текущий уровень топлива в баке: {FuelLevel} , оставил денег и поехал");
                }
                
            }
        }
    }

}
