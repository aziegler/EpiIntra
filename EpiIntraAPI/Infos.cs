using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiIntraAPI
{
    class Infos
    {
        private string token;
        private string url;

        public Infos(string url, string token)
        {
            this.url = url;
            this.token = token;
        }
    }
}
