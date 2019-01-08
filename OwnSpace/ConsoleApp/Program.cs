using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Config;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var serviceType = ConfigurationManager.AppSettings["ServiceType"];
                var logCfg = new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config");
                XmlConfigurator.ConfigureAndWatch(logCfg);

                IWork work = null;

                switch (serviceType)
                {
                    case "SendMessage":
                        work = new SendMessage();
                        break;
                }
                work?.DoWork();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
