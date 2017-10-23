using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoxVolumeCalculaterWCFConsumer.ServiceReference1;

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
            using (var consumerVolume = new Service1Client("BasicHttpBinding_IService1"))
            {
                consumerVolume.GetVolume(2, 2, 2);
                Console.WriteLine(consumerVolume);
            }

            using (var consumerSide = new Service1Client("BasicHttpBinding_IService1"))
            {
                consumerSide.GetSide(8, 2, 2);
                Console.WriteLine(consumerSide);
            }
        }
    }
}
