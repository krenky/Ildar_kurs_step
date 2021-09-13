﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs_step1_2
{
    class Clients
    {
        int _countClient;      //поле количества клиентов
        Client[] _arrayClients;//поле массив клиентов
        int _sizeArray;        //поле размер массива
        int _lastClient;       //поле индекс последнего элемента(индекс первого элемента всегда равен 0)

        public Clients(int sizeArray)//конструктор
        {
            SizeArray = sizeArray;
            CountClient = 0;
            ArrayClients = new Client[sizeArray];
            LastClient = -1;
        }

        public int CountClient { get => _countClient; set => _countClient = value; }
        public int SizeArray { get => _sizeArray; set => _sizeArray = value; }
        internal Client[] ArrayClients { get => _arrayClients; set => _arrayClients = value; }
        public int LastClient { get => _lastClient; set => _lastClient = value; }

        public bool AddClient(int clientId)//метод добавления клиента
        {
            Client client = new Client(clientId);
            ArrayClients[CountClient] = client;
            CountClient++;
            LastClient++;
            if(CountClient == SizeArray)
            {
                SizeArray *= 2;
                Array.Resize(ref _arrayClients, SizeArray);
                return true;
            }
            return false;
        }
        public bool DeleteClient()//метод удаления клиента
        {
            if(CountClient != 0)
            {
                ArrayClients[0] = null;
                for(int i = 1; i < CountClient; i++)
                    ArrayClients[i - 1] = ArrayClients[i];
                CountClient--;
                LastClient--;
                return true;
            }
            return false;
        }
        public Client FindClient(int clientId)//метод поиска клиента
        {
            for(int i = 0; i < CountClient; i++)
            {
                if(ArrayClients[i].ClientId == clientId)
                {
                    return ArrayClients[i];
                }
            }
            return null;
        }
        public int SumClients()//метод подсчета суммы всех заказов
        {
            int SumClients = 0;
            for(int i = 0; i < CountClient; i++)
            {
                SumClients += ArrayClients[i].SumRide();
            }
            return SumClients;
        }
        public string AllInfo()//метод всей информации
        {
            string AllData = "Клиенты:\n";
            for(int i = 0; i < CountClient; i++)
            {
                if (ArrayClients[i] != null)
                {
                    AllData += "ClientId : " + ArrayClients[i].ClientId + "\n" + ArrayClients[i].InfoClient() +
                    "\n=======================================================\n";
                }
            }
            AllData += $"Сумма всех заказов{SumClients()}";
            return AllData;
        }
    }
}
