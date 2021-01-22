using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class ClientManager
    {
        public void Add(Client client)
        {
            Console.WriteLine($"{ client.Id} numaralı müşteri {client.Name} {client.Surname}, sisteme eklendi.");
        }

        public void Remove(Client client)
        {
            Console.WriteLine($"{ client.Id} numaralı müşteri {client.Name} {client.Surname}, sistemden kaldırıldı.");
        }

        public void List(Client[] clients)
        {
            foreach (var client in clients)
            {
                Console.WriteLine($"{client.Id} numaralı müşterinin adı ve soyadı : {client.Name} {client.Surname}, doğduğu şehir: {client.Birthplace}");
            }
        }
    }
}
