using System;
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
            
        }

        public int CountClient { get => _countClient; set => _countClient = value; }
        public int SizeArray { get => _sizeArray; set => _sizeArray = value; }
        internal Client[] ArrayClients { get => _arrayClients; set => _arrayClients = value; }
        public int LastClient { get => _lastClient; set => _lastClient = value; }

        public bool AddClient(int clientId)//метод добавления клиента
        {
            
        }
        public Client FindClient(int clientId)//метод поиска клиента
        {
            
        }
        public int SumClients()//метод подсчета суммы всех заказов
        {
            
        }
        public string AllInfo()//метод всей информации
        {
            
        }
    }
}
