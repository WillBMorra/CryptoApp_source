using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfApp2
{
    internal class Asset_Installer
    {
        public async void SetList()
        {
            string link = "https://cryptingup.com/api/assets";
            FileMenu bb = new FileMenu();
            using var client = new HttpClient();




            var msg = new HttpRequestMessage(HttpMethod.Get, link);

            var res = await client.SendAsync(msg);

            var content = await res.Content.ReadAsStringAsync();

            var builder = new UriBuilder(link);

            string kek = content;

            var abc = client.GetStringAsync(link);
            content.GetTypeCode();


            var result = content.Substring(content.IndexOf("["), content.LastIndexOf("]") - content.IndexOf("[") + 1);

            bb.Write(result);



        }



        public List<assets> GetAssets()
        {
            SetList();
            int counter = 0;
            var incoming = new List<assets>();
            List<assets> a = new List<assets>();


            using (StreamReader r = new StreamReader("Test.json"))
            {
                string json = r.ReadToEnd();
                incoming = JsonSerializer.Deserialize<List<assets>>(json);
            }


            if (incoming != null && incoming.Count > 0)
            {

                foreach (var customer in incoming)
                {
                    if (customer.name != "") 
                    {
                        a.Add(customer);
                        counter++;
                    }
                }


            
            }
            return a;
            
        }
        public void SortByInt(List<assets> assets, int len = 0) 
        {
            assets temp = new assets();
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (assets[j].price < assets[j + 1].price)
                    {
                        temp = assets[j];
                        assets[j] = assets[j+1];
                        assets[j + 1] = temp;
                    }
                }
            }
        }

        public void SortByName(List<assets> assets, int len = 0) 
        {
            assets temp = new assets();
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (String.Compare(assets[j].name, assets[j+1].name) == 1)
                    {
                        temp = assets[j];
                        assets[j] = assets[j + 1];
                        assets[j + 1] = temp;
                    }
                }
            }
        }
    }

    
}
