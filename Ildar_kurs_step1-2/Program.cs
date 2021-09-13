using System;

namespace kurs_step1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Menu = 0;
            int clientId;
            int price;
            DateTime dateTime;

            Console.WriteLine("enter the size of the store ");
            Clients ClientsBd = new Clients(Convert.ToInt32(Console.ReadLine()));
            while (Menu != 7)
            {
                Console.WriteLine("1: add client");
                Console.WriteLine("2: delete client");
                Console.WriteLine("3: view client information");
                Console.WriteLine("4: add ride ");
                Console.WriteLine("5: delete ride ");
                Console.WriteLine("6: view all information");
                Console.WriteLine("7: exit");
                Menu = Convert.ToInt32(Console.ReadLine());
                switch (Menu)
                {
                     case 1:
                        Console.WriteLine("enter the clientId ");
                        clientId = Convert.ToInt32(Console.ReadLine());
                        if (ClientsBd.AddClient(clientId))
                        {
                            Console.WriteLine("Array was extended");
                        } 
                        break;
                    case 2:
                        ClientsBd.DeleteClient();
                        break;
                    case 3:
                        Console.WriteLine("enter the clientId");
                        clientId = Convert.ToInt32(Console.ReadLine());
                        Client findclient = ClientsBd.FindClient(clientId);
                        if (findclient != null)
                        {
                            Console.WriteLine(findclient.InfoClient());
                        }
                        else Console.WriteLine("wrong name");
                        break;
                    case 4:
                        Console.WriteLine("enter the clientId");
                        clientId = Convert.ToInt32(Console.ReadLine());
                        findclient = ClientsBd.FindClient(clientId);
                        if (findclient != null)
                        {
                            Console.WriteLine("Enter ride price");
                            price = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter date(yyyy;mm;dd)");
                            dateTime = new DateTime(Convert.ToInt32(Console.ReadLine()), 
                                Convert.ToInt32(Console.ReadLine()), 
                                Convert.ToInt32(Console.ReadLine()));
                            findclient.AddRide(dateTime, price);
                        }
                        else 
                            Console.WriteLine("wrong name");
                        break;
                    case 5:
                        Console.WriteLine("enter the clientId");
                        clientId = Convert.ToInt32(Console.ReadLine());
                        findclient = ClientsBd.FindClient(clientId);
                        Console.WriteLine("Enter date(yyyy;mm;dd)");
                        dateTime = new DateTime(Convert.ToInt32(Console.ReadLine()),
                            Convert.ToInt32(Console.ReadLine()),
                            Convert.ToInt32(Console.ReadLine()));
                        findclient.DeleteRide(dateTime);
                        break;
                    case 6:
                        Console.WriteLine(ClientsBd.AllInfo());
                        break;
                }
            }
        }
    }
}
