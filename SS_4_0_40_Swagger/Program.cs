using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
using System.Diagnostics;

namespace SS_4_0_40_Swagger
{
    public class Program
    {
        static int Main(string[] args)
        {
            UInt16 port = 9443;

            String urlBase = BuildBaseUrl("*", port); //"https://*:" + port + "/api/";

            ServiceStackHost appHost = new AppHost().Init().Start(urlBase);

#if DEBUG
            Process.Start(String.Format("https://localhost:" + port + "/api/" + GetApiVersion() + "/swagger-ui"));
#endif
            Console.ReadLine();
            return 0;
        }

        private static string BuildBaseUrl(string hostName, UInt16 port)
        {
            return "https://" + hostName + ":" + port + "/api/" + GetApiVersion() + "/";
        }

        private static string GetApiVersion()
        {
            return "v1";
        }
    }
}
