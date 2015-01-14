using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiIntraAPI
{
    class Mark
    {
        private double year;
        private string moduleCode;
        private string moduleTitle;
        private string codeInstance;
        private string activity;
        private string title;
        private string date;
        private string correcteur;
        private double mark;
        private string comment;

        public Mark()
        {
        }

        public void setYear(double year)
        {
            this.year = year;
        }

        public double getYear()
        {
            return year;
        }

        public void setModuleCode(string moduleCode)
        {
            this.moduleCode = moduleCode;
        }

        public string getModuleCode()
        {
            return moduleCode;
        }

        public void setModuleTitle(string moduleTitle)
        {
            this.moduleTitle = moduleTitle;
        }

        public string getModuleTitle()
        {
            return moduleTitle;
        }

        public void setCodeInstance(string codeInstance)
        {
            this.codeInstance = codeInstance;
        }

        public string getCodeInstance()
        {
            return codeInstance;
        }

        public void setActivity(string activity)
        {
            this.activity = activity;
        }

        public string getActivity()
        {
            return activity;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public string getTitlte()
        {
            return title;
        }

        public void setDate(string date)
        {
            this.date = date;
        }

        public string getDate()
        {
            return date;
        }

        public void setCorrecteur(string correcteur)
        {
            this.correcteur = correcteur;
        }

        public string getCorrecteur()
        {
            return correcteur;
        }

        public void setMark(double mark)
        {
            this.mark = mark;
        }
        
        public double getMark()
        {
            return mark;
        }

        public void setComment(string comment)
        {
            this.comment = comment;
        }

        public string getComment()
        {
            return comment;
        }
    }
}
