using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class ClientManager
    {
        public void AddClient(Client client)
        {
            Console.WriteLine("Client added >>>" + 
                                "Id :"+ client.Id + " // "+
                                " Name : " + client.Name + " // " +
                                " Surname : " + client.Surname + " // " +
                                " Age : " + client.Age + " // " +
                                " City : " + client.City  );

        }
        public void ShowClientInfos(Client client)
        {
            Console.WriteLine("Client added >>>" +
                                "Id :" + client.Id + " // " +
                                " Name : " + client.Name + " // " +
                                " Surname : " + client.Surname + " // " +
                                " Age : " + client.Age + " // " +
                                " City : " + client.City);


        }
        public void DeleteClient(Client client)
        {
            Console.WriteLine("Client added >>>" +
                                "Id :" + client.Id + " // " +
                                " Name : " + client.Name + " // " +
                                " Surname : " + client.Surname + " // " +
                                " Age : " + client.Age + " // " +
                                " City : " + client.City);

        }
    }
}
