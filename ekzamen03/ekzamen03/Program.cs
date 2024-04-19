using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekzamen03
{
    class Program
    {
        class Trip // туристическая поездка
        {
            public string duration; // продолжительность
            public int price; // цена
            public int size; // размер группы

        }

        class TouristicOperator // туристический оператор
        {
            private int n = 0;
            public Trip[] trips;

            public TouristicOperator(int n)
            {
                this.n = n;
                trips = new Trip[n];
            }

            public void SortTrip() // сортировка по двум свойствам
            {
                trips = trips.OrderBy(p => p.price).ThenByDescending(s => s.size).ToArray();
            }

            public void WriteToFile(StreamWriter sw, int n)
            {
                for(int i = 0; i<n; i++)
                {
                    sw.WriteLine("Продолжительность: " + trips[i].duration);
                    sw.WriteLine("Цена: " + trips[i].price);
                    sw.WriteLine("Размер группы: " + trips[i].size);
                    sw.WriteLine();
                }
            }

            public void Print()
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Продолжительность: " + trips[i].duration);
                    Console.WriteLine("Цена: " + trips[i].price);
                    Console.WriteLine("Размер группы: " + trips[i].size);
                    Console.WriteLine();
                }
            }

        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество тур. поездок: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            TouristicOperator trips = new TouristicOperator(n);
            for(int i = 0; i < n; i++)
            {
                trips.trips[i] = new Trip();
                Console.Write("Введите продолжительность поездки: ");
                trips.trips[i].duration = Console.ReadLine();
                Console.Write("Введите цену поездки: ");
                trips.trips[i].price = int.Parse(Console.ReadLine());
                Console.Write("Введите размер группы: ");
                trips.trips[i].size = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            trips.SortTrip();
            


        }
    }
}
