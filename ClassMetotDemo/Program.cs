using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client { Id = 1, Name = "Ali", Surname = "Baran", Age = 30, City = "Baku"};
            Client client2 = new Client { Id = 2, Name = "Kerem", Surname = "Bilgin", Age = 33, City = "Izmir"};
            Client client3 = new Client { Id = 3, Name = "Turgay", Surname = "Mustafa", Age = 29, City = "Istanbul"};
            Client client4 = new Client { Id = 4, Name = "Hasan", Surname = "Ahmet", Age = 35, City = "Antalya"};
            Client client5 = new Client { Id = 5, Name = "Oguz", Surname = "Turan", Age = 28, City = "Van" };

            ClientManager clientManager = new ClientManager();
            clientManager.AddClient(client1);
            clientManager.AddClient(client2);
            clientManager.AddClient(client3);
            clientManager.AddClient(client4);
            clientManager.AddClient(client5);
            Console.WriteLine("******************************************************************************************");

            clientManager.ShowClientInfos(client1);
            clientManager.ShowClientInfos(client2);
            clientManager.ShowClientInfos(client3);
            clientManager.ShowClientInfos(client4);
            clientManager.ShowClientInfos(client5);
            Console.WriteLine("******************************************************************************************");


            clientManager.DeleteClient(client2);
            clientManager.DeleteClient(client4);
        }
    }
}
