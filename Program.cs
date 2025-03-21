using System;

namespace OCP
{
    class Program
    {
        static void Main()
        {
            PaymentSystemProvider provider = new PaymentSystemProvider();
            OrderForm orderForm = new OrderForm();
            

            string systemId = orderForm.ChooseSystem(provider.FabricIds);

            if (Enum.IsDefined(typeof(PaymentSystemTypes), (PaymentSystemTypes)Convert.ToInt32(systemId)) == false)
            {
                Console.WriteLine("Такой системы нет.");
                Console.ReadKey();
                return;
            }

            PaymentHandler handler = new PaymentHandler(provider.GetPaymentSystemFabric(systemId).Create());
            handler.ShowPaymentResult();
            Console.ReadKey();
        }
    }
}
