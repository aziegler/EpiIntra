using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiIntraAPI
{
    class Message
    {
        private string title;
        private string user;
        private string content;
        private string date;

        public Message()
        {
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public void setUser(string user)
        {
            this.user = user;
        }

        public void setContent(string content)
        {
            this.content = content;
        }

        public void setDate(string date)
        {
            this.date = date;
        }

        public string getTitle()
        {
            return title;
        }

        public string getUser()
        {
            return user;
        }

        public string getContent()
        {
            return content;
        }

        public string getDate()
        {
            return date;
        }
    }
}
