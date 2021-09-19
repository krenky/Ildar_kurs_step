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
        Ride _head;     //поле поездок
        Ride lastRide;  //указатель на последную поездку
        Ride prevRide;  //указатель на предыдущую поездку

        public Client(int clientId)//конструктор
        {
            ClientId = clientId;
            CountOrder = 0;
            Head = new Ride(new DateTime(0001, 1, 1), 0);
            LastRide = null;
            PrevRide = _head;
        }
        public int ClientId { get => id; set => id = value; }
        public int CountOrder { get => countOrder; set => countOrder = value; }
        public Ride Head { get => _head; set => _head = value; }
        internal Ride LastRide { get => lastRide; set => lastRide = value; }
        internal Ride PrevRide { get => prevRide; set => prevRide = value; }

        public bool AddRide(DateTime dateTime, int price)//метод добавления поездки
        {
            bool check = true;
            Ride prev = Head;
            Ride current = Head.Next;
            Ride newRide = new Ride(dateTime, price);
            if(countOrder == 0){
                Head.Next = newRide;
                LastRide = newRide;
            }
            else
            {
                while(current != null)
                {
                    if(DateTime.Compare(newRide.DateTime, current.DateTime) < 0)
                    {
                        newRide.Next = current;
                        prev.Next = current;
                        check = false;
                        break;
                    }
                    else
                    {
                        prev = current;
                        current = current.Next;
                    }
                }
                if(check)
                {
                    LastRide.Next = newRide;
                    LastRide = newRide;
                }
            }
            countOrder++;
            return true;
        }
        public bool DeleteRide(DateTime dateTime)//метод удаления поездки
        {
            if(countOrder != 0)
            {
                Ride current = FindRide(dateTime);
                if(current == null)
                {
                    return false;
                }
                else
                {
                    if(current != LastRide)
                    {
                        PrevRide.Next = current.Next;
                        current = null;
                        countOrder--;
                        return true;
                    }
                    else
                    {
                        LastRide = PrevRide;
                        LastRide.Next = null;
                        current = null;
                        countOrder--;
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }
        }
        public Ride FindRide(DateTime dateTime)//метод поиска поездки
        {
            Ride current = Head.Next;
            while(current != null)
            {
                if(current.DateTime == dateTime)
                {
                    return current;
                }
                else
                {
                    PrevRide = current;
                    current = current.Next;
                }
            }
            return null;
        }
        public int SumRide()//метод подсчета суммы всех заказов
        {
            Ride current = Head.Next;
            int SumRide = 0;
            while(current != null)
            {
                SumRide += current.Price;
                current = current.Next;
            }
            return SumRide;
        }
        public string InfoClient()//метод получения ифнормации
        {
            Ride current = Head.Next;
            string dataClient = "";
            if (current != null)
            {
                dataClient = $"Кол-во заказов: {CountOrder}\n " +
                $"последний заказ : \n" +
                $"Цена : {LastRide.Price}\n" +
                $"Время : {LastRide.DateTime}\n" +
                "поездки:\n";
                while (current != null)
                {
                    dataClient += $"Цена : {current.Price} Время : {current.DateTime}\n";
                    current = current.Next;
                }
            }
            else
            {
                dataClient = $"Кол-во заказов: {CountOrder}\n ";
            }
            return dataClient;
        }
    }
}
