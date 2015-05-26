using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;
using Funq;
using ServiceStack.Api.Swagger;

namespace SS_4_0_40_Swagger
{
    public class AppHost : AppSelfHostBase
    {
        public AppHost()
            : base("ServiceStackSelfHost1", typeof(MyServices).Assembly)
        {

        }

        public override void Configure(Container container)
        {

            SetConfig(new HostConfig { DebugMode = true });

            Plugins.Add(new SwaggerFeature());
        }
    }
}
