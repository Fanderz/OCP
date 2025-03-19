using System;
using System.Collections.Generic;

namespace OCP
{
    class OrderForm
    {
        public string ChooseSystem(IEnumerable<string> fabricsIds)
        {

            Console.WriteLine($"Мы принимаем: ");

            foreach (var item in fabricsIds)
                Console.WriteLine($"{item} - {(PaymentSystemTypes)Convert.ToInt32(item)}");

            //симуляция веб интерфейса
            Console.WriteLine("Какое системой вы хотите совершить оплату?");

            string systemId = Console.ReadLine();

            return systemId;
        }
    }
}
