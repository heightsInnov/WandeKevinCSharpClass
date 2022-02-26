using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using WandeKevin;

namespace WandeKevin
{
    internal class School
    {
        public string name { set; get; }
        public string location { set; get; }
        public string type { set; get; }
        public string contactPhoneNumber { set; get; }
        public int studentSize { set; get; }
        public string website { set; get; }
        public string[] colours { set; get; }
        public decimal rating { set; get; }

        public School(string name)
        {
            this.name = name;
        }

        public School(string name, string website)
        {
            this.name = name;
            this.website = website;
        }

        public School(string name, string city, int rating)
        {
            this.name = name;
            this.location = city;
            this.rating = rating;
        }


        public School(string name, string city, string type)
        {
            this.name = name;
            this.location = city;
            this.type = type;
        }

    }

}

