using System;
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
        }

        static void Main(string[] args)
        {
        }
    }
}
