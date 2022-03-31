using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace consumewebapicore.Configuration
{
    public class studentApi
    {
        public HttpClient initial()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:54609/");
            return client;
        }
    }
}
