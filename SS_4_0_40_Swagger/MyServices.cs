using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack;

namespace SS_4_0_40_Swagger
{
    [Api("Just saying hello")]
    [Route("/hello", "GET")]
    public class Hello : IReturn<HelloResponse>
    {
        [ApiMember(Name = "Guid", Description = "A unique guid ", ParameterType = "query",
                    DataType = "String", IsRequired = false)]
        public String Guid { get; set; }

    }

    public class HelloResponse
    {
        public String Guid { get; set; }
    }

    public class MyServices : Service
    {
        public object Get(Hello requestDto)
        {
            return new HelloResponse();
        }
    }
}
