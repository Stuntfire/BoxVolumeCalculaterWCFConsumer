using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoxVolumeCalculaterWCFConsumer.ServiceReference1;
using BoxVolumeCalculaterWCFConsumer.ServiceReferenceToAzure;

namespace BoxVolumeCalculaterWCFConsumer
{
    class Program
    {
        /// <summary>
        /// link til wsdl-filen på Azure: http://boxvolumecalculaterwcfazure.azurewebsites.net/Service1.svc?wsdl
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Service on Azure
            using (var client = new ServiceReferenceToAzure.Service1Client("BasicHttpBinding_IService11"))

            ////Localhost version
            //using (var client = new Service1Client("BasicHttpBinding_IService1"))
            {
                var volume = client.GetVolume(34.4, 23.1, 4.5);

                var side = client.GetSide(67289, 23.8, 10.3);

                Console.WriteLine($"Volume is: {volume}");

                Console.WriteLine($"\nSide is: {side}");
            }
        }
    }
}
