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

            if (Enum.IsDefined(typeof(PaymentSystemTypes), (PaymentSystemTypes)Convert.ToInt32(systemId)) == false)
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
