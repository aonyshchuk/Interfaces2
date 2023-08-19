using System.Collections.Specialized;
using System.Text;
using Interfaces2.Domain.Models;
using Interfaces2.Domain.NewFolder;
using Interfaces2.Domain.UseCases;
using Device = Interfaces2.Domain.Models.Device;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)


        {

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            bool Input = true; 

            Device device = new Device("Пристрій");
            Car car = new Car("Тесла");
            Kettle kettle = new Kettle("Чайник електронний");
            Microwave microwave = new Microwave("Мікрохвильовка звичайна");
            Steamship steamship = new Steamship("Пароплав швидкий");

            while (Input)
            {
                Console.WriteLine("Транспортні засоби");
                Console.WriteLine();
                Console.WriteLine("Для перегляду наземних т.з. натисніть 1, водних - 2");
                int task1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (task1)
                {
                    case 1:
                        Trip.ShowTrip(car);
                        car.Sound();
                        car.Desc();
                        Console.WriteLine();
                        break;

                    case 2:
                        Trip.ShowTrip(steamship);
                        steamship.Sound();
                        steamship.Desc();
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Error");
                        Console.WriteLine();
                        break;
                }


                Console.WriteLine("Пристрої для приготування їжі");
                Console.WriteLine();
                Console.WriteLine("Для перегляду засобів для кип'ятіння води натисніть 1, приготування їжі - 2");
                int task2 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (task2)
                {
                    case 1:
                        BoilingWater.ShowBoiliningDevice(kettle);
                        kettle.Sound();
                        kettle.Desc();
                        Console.WriteLine();
                        break;

                    case 2:
                        BoilingWater.ShowBoiliningDevice(microwave);
                        microwave.Sound();
                        microwave.Desc();
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Error");
                        Console.WriteLine();
                        break;
                }
            }

        }
    }
}