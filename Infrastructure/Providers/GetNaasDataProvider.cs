using Core_.Entities;
using Core_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Infrastructure.Providers
{
    public class GetNaasDataProvider : IGetNaasDataProvider
    {
        public GetNaasDataProvider() { }
        
        public Naas GetNewNaasdata()
        {
            Naas naas = new Naas();
            HttpClient client = new HttpClient();
            var response = client.GetAsync("https://localhost:55312").Result;
            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                naas.Text = json.ToString();
            }
            return naas;
        }
    }
}
