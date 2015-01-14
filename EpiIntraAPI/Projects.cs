using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiIntraAPI
{
    class Projects
    {
        private string token;
        private string url;

        public Projects(string url, string token)
        {
            this.url = url;
            this.token = token;
        }
    }
}
