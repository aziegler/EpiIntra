using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EpiIntraAPI
{

    public class GetDataFromIntra
    {
        public string url = "";
        private string login;
        private string password;

        public GetDataFromIntra(string url, string login, string password)
        {
            this.url = url;
            this.login = login;
            this.password = password;
        }
    }
}
