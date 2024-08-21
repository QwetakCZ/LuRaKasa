using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace DeskopLuRaKasa.Services
{
    internal class MyHttpClient : HttpClient
    {
        public MyHttpClient()
        {
            this.BaseAddress = new Uri("http://localhost:5195/");
        }
    }
}
