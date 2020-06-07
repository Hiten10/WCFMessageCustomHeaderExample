using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCF.MessageHeader.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageInspector.CorrelationID = "1234-56789-012";
            using (ServiceReference1.Service1Client client = new ServiceReference1.Service1Client())
            {
                Console.WriteLine(client.GetData(1));
            }
            Console.ReadKey();

        }
    }
}
