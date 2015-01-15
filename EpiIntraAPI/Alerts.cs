using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Windows.Data.Json;

namespace EpiIntraAPI
{
    class Alerts
    {
        private string token;
        private string url;

        public Alerts(string url, string token)
        {
            this.url = url;
            this.token = token;
        }

        public List<string> getAlerts()
        {
            List<string> list = new List<string>();
            Uri uri = new Uri(url);
            HttpWebRequest request = WebRequest.CreateHttp(uri + "/alerts?token=" + token);
            request.GetResponseAsync();
            WebResponse response = request.GetResponseAsync().Result;
            string str = response.GetResponseStream().ToString();
            JsonArray jso = JsonArray.Parse(str);
            int cpt = 0;
            while (cpt < jso.Count)
            {
                JsonObject obj = JsonObject.Parse(jso[cpt].ToString());
                list.Add(obj.GetNamedString("title", ""));
                cpt++;
            }
            return (list);
        }
    }
}
