using System;

namespace OCP
{
    class Program
    {
        static void Main()
        {
            PaymentSystemProvider provider = new PaymentSystemProvider();
            OrderForm orderForm = new OrderForm();

            var systemId = orderForm.ChooseSystem(provider.FabricIds);

            if (systemId <= 0 || Enum.IsDefined(typeof(PaymentSystemTypes), systemId) == false)
            {
                Console.WriteLine("Такой системы нет.");
                Console.ReadKey();
                return;
            }

            provider.GetPaymentSystemFabric(systemId).Create().ShowPaymentResult();
            Console.ReadKey();
        }
    }
}
