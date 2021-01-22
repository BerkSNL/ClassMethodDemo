using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Client müsteri1 = new Client();
            müsteri1.Id = 1;
            müsteri1.Name = "Mahmut";
            müsteri1.Surname = "Tuncer";
            müsteri1.Birthplace = "Şanlıurfa";

            Client müsteri2 = new Client();
            müsteri2.Id = 2;
            müsteri2.Name = "Bülent";
            müsteri2.Surname = "Ersoy";
            müsteri2.Birthplace = "İstanbul";


            Client[] clients = new Client[] { müsteri1, müsteri2 };

            ClientManager clientManager = new ClientManager();
            clientManager.Add(müsteri1);
            clientManager.Add(müsteri2);
            Console.WriteLine("\n");
            clientManager.Remove(müsteri2);
            Console.WriteLine("\n");
            clientManager.List(clients);

        }
    }
}
