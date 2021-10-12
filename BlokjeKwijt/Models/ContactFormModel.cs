using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlokjeKwijt.Models
{
    public class ContactFormModel
    {
        private string name { get; set; }
        private string email { get; set; }
        private string phonenumber { get; set; }
        private string message { get; set; }
        public ContactFormModel(string name, string email, string phonenumber, string message)
        {
            this.name = name;
            this.email = email;
            this.phonenumber = phonenumber;
            this.message = message;
        }
    }
}
