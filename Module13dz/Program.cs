using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13dz
{
    class Program
    {
        static void Main()
        { 
            Queue<Client> clientQueue = new Queue<Client>();

            clientQueue.Enqueue(new Client(1, "Aiym", "Коллцентр"));
            clientQueue.Enqueue(new Client(2, "Асыл", "Хелпдеск"));
            clientQueue.Enqueue(new Client(3, "Ару", "Юр"));

            while (clientQueue.Count > 0)
            {
                Client currentClient = clientQueue.Dequeue();
                Console.WriteLine($"Обслуживаем клиента {currentClient.Name} (ID: {currentClient.Id}, Тип обслуживания: {currentClient.ServiceType})");
            }
            Console.ReadKey();
        }
    }

}
