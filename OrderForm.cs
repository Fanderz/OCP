using System;
using System.Collections.Generic;

namespace OCP
{
    class OrderForm
    {
        public int ChooseSystem(IEnumerable<int> fabricsIds)
        {

            Console.WriteLine($"Мы принимаем: ");

            foreach (var item in fabricsIds)
                Console.WriteLine($"{item} - {(PaymentSystemTypes)item}");

            //симуляция веб интерфейса
            Console.WriteLine("Какое системой вы хотите совершить оплату?");

            if (int.TryParse(Console.ReadLine(), out int systemId))
                return systemId;
            else
                return -1;
        }
    }
}
