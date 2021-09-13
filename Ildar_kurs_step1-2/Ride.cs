using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs_step1_2
{
    /// <summary>
    /// Класс поездки
    /// </summary>
    class Ride
    {
        DateTime _dateTime;//поле даты и времени
        int _price;        //поле цены поездки
        Ride _next;        //поле ссылка на следующую поездку
        Ride _head;        //головной элемент

        public Ride(DateTime dateTime, int price)//конструктор
        {
            DateTime = dateTime;
            Price = price;
        }

        public DateTime DateTime { get => _dateTime; set => _dateTime = value; }
        public int Price { get => _price; set => _price = value; }
        internal Ride Next { get => _next; set => _next = value; }
        internal Ride Head { get => _head; set => _head = value; }
    }
}
