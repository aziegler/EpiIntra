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

        public GetDataFromIntra(string url, string login, string password)
        {
            if (url != null && url != "")
                this.url = url;
            this.login = login;
            this.password = password;
        }

        public string getToken()
        {
            Uri uri = new Uri(url);
            WebRequest request = WebRequest.Create(uri + "/login");
            JsonObject jso = new JsonObject();
            jso.Add("login", JsonValue.CreateStringValue(login));
            jso.Add("password", JsonValue.CreateStringValue(password));
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Method = "POST";
            request.ContentType = "text/json";
        }
    }
}
