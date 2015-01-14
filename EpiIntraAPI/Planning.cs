using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiIntraAPI
{
    class Planning
    {
        private string from;
        private string to;
        private string token;
        private string url;

        public Planning(string from, string to, string url, string token)
        {
            this.from = from;
            this.to = to;
            this.url = url;
            this.token = token;
        }
    }
}
