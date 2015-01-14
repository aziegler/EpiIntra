using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Windows.Data.Json;

namespace EpiIntraAPI
{
    class Marks
    {
        private string token;
        private string url;

        public Marks(string url, string token)
        {
            this.url = url;
            this.token = token;
        }

        public List<Mark> getMessages()
        {
            List<Mark> list = new List<Mark>();
            Uri uri = new Uri(url);
            HttpWebRequest request = WebRequest.CreateHttp(uri + "/marks?token=" + token);
            request.GetResponseAsync();
            WebResponse response = request.GetResponseAsync().Result;
            string str = response.GetResponseStream().ToString();
            JsonObject o = JsonObject.Parse(str);
            JsonArray jso = JsonArray.Parse(o.GetNamedString("notes"));
            int cpt = 0;
            while (cpt < jso.Count)
            {
                Mark m = new Mark();
                JsonObject obj = JsonObject.Parse(jso[cpt].ToString());
                m.setYear(obj.GetNamedNumber("scolaryear"));
                m.setModuleCode(obj.GetNamedString("codemodule"));
                m.setModuleTitle(obj.GetNamedString("titlemodule"));
                m.setCodeInstance(obj.GetNamedString("codeinstance"));
                m.setActivity(obj.GetNamedString("codeacti"));
                m.setTitle(obj.GetNamedString("title"));
                m.setDate(obj.GetNamedString("date"));
                m.setCorrecteur(obj.GetNamedString("correcteur"));
                m.setMark(obj.GetNamedNumber("final_note"));
                m.setComment(obj.GetNamedString("comment"));
                list.Add(m);
            }
            return (list);
        }
    }
}
