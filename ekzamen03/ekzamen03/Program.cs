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
            private Trip[] trips;

            public TouristicOperator(int n)
            {
                this.n = n;
                trips = new Trip[n];
            }

            /*public void SortTrip()
            {
                trips = trips.OrderBy
            }*/

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

        }

        static void Main(string[] args)
        {
        }
    }
}
