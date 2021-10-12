using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlokjeKwijt.Models
{
    public class ColorModel
    {
        private string name { get; set; }
        private int hex { get; set; }
        public ColorModel(string name, int hex)
        {
            this.name = name;
            this.hex = hex;
        }

    }
}
