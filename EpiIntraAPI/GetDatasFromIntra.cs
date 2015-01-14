using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Linq;
using Windows.Data.Json;

namespace EpiIntraAPI
{

    public class GetDataFromIntra
    {
        public string url = "https://epitech-api.herokuapp.com/";
        protected string login;
        protected string password;
        private string token = null;
        private Infos infos;
        private Modules modules;
        private Projects projects;
        private Marks marks;
        private Messages messages;
        private Alerts alerts;

        /*
         * Fonction principale de notre api,
         * on lui envoie le lien de l'api, le login de l'élève,
         * ainsi que le mot de passe (en clair :'( )
         * 
         * @params url, login, password
         */
        public GetDataFromIntra(string url, string login, string password)
        {
            if (url != null && url != "")
                this.url = url;
            this.login = login;
            this.password = password;
            // On récupère le token en forçant la récupération
            getToken(true);
            // On initialise l'api complétement grâce au token récupéré
            infos = new Infos(this.url, token);
            modules = new Modules(this.url, token);
            projects = new Projects(this.url, token);
            marks = new Marks(this.url, token);
            messages = new Messages(this.url, token);
            alerts = new Alerts(this.url, token);
        }

        /*
         * Autre constucteur de notre fonction principale,
         * on lui envoie le login de l'élève,
         * ainsi que le mot de passe (en clair :'( )
         * 
         * @params login, password
         */
        public GetDataFromIntra(string login, string password)
        {
            this.login = login;
            this.password = password;
            // On récupère le token en forçant la récupération
            getToken(true);
            // On initialise l'api complétement grâce au token récupéré
            infos = new Infos(this.url, token);
            modules = new Modules(this.url, token);
            projects = new Projects(this.url, token);
            marks = new Marks(this.url, token);
            messages = new Messages(this.url, token);
            alerts = new Alerts(this.url, token);
        }

        public void getToken(bool force)
        {
            if (token == null || force)
            {
                Uri uri = new Uri(url);
                HttpWebRequest request = WebRequest.CreateHttp(uri + "/login?login=" + login + "&password=" + password);
                request.GetResponseAsync();
                WebResponse response = request.GetResponseAsync().Result;
                string s = response.GetResponseStream().ToString();
                JsonObject jso = JsonObject.Parse(s);
                token = jso.GetNamedString("token", null);
            }
        }

        public Infos getInfos()
        {
            return infos;
        }

        public Modules getModules()
        {
            return modules;
        }

        public Projects getProjects()
        {
            return projects;
        }

        public Planning getPlanning(string from, string to)
        {
            return new Planning(from, to, url, token);
        }

        public Marks getMarks()
        {
            return marks;
        }

        public Messages getMessages()
        {
            return messages;
        }

        public Alerts getAlerts()
        {
            return alerts;
        }
    }
}
