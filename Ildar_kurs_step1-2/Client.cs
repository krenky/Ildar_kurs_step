using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs_step1_2
{
    /// <summary>
    /// Класс клиент
    /// </summary>
    class Client
    {
        int id;         //поле номера клиента
        int countOrder; //поле заказов
        Ride rides;     //поле поездок
        Ride lastRide;  //указатель на последную поездку
        Ride prevRide;  //указатель на предыдущую поездку

        public Client(int clientId)//конструктор
        {
            
        }
        public int ClientId { get => id; set => id = value; }
        public int CountOrder { get => countOrder; set => countOrder = value; }
        public Ride Rides { get => rides; set => rides = value; }
        internal Ride LastRide { get => lastRide; set => lastRide = value; }
        internal Ride PrevRide { get => prevRide; set => prevRide = value; }

        public bool AddRide(DateTime dateTime, int price)//метод добавления поездки
        {
            
        }
        public bool DeleteRide(DateTime dateTime)//метод удаления поездки
        {
            
        }
        public Ride FindRide(DateTime dateTime)//метод поиска поездки
        {
            
        }
        public int SumRide()//метод подсчета суммы всех заказов
        {
            
        }
        public string InfoClient()//метод получения ифнормации
        {
            
        }
    }
}
