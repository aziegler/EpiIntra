using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Windows.Data.Json;

namespace EpiIntraAPI
{
    class Messages
    {
        private string token;
        private string url;

        public Messages(string url, string token)
        {
            this.url = url;
            this.token = token;
        }

        public List<Message> getMessages()
        {
            List<Message> list = new List<Message>();
            Uri uri = new Uri(url);
            HttpWebRequest request = WebRequest.CreateHttp(uri + "/messages?token=" + token);
            request.GetResponseAsync();
            WebResponse response = request.GetResponseAsync().Result;
            string str = response.GetResponseStream().ToString();
            JsonArray jso = JsonArray.Parse(str);
            int cpt = 0;
            while (cpt < jso.Count)
            {
                Message m = new Message();
                JsonObject obj = JsonObject.Parse(jso[cpt].ToString());
                m.setTitle(obj.GetNamedString("title"));
                m.setUser(JsonObject.Parse(obj.GetNamedString("user")).GetNamedString("title"));
                m.setContent(obj.GetNamedString("content"));
                m.setDate(obj.GetNamedString("date"));
                list.Add(m);
            }
            return (list);
        }
    }
}
