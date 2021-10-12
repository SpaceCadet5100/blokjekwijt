using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlokjeKwijt.Models
{
    public class BlokjeModel
    {
        private int width { get; set; }
        private int lenght { get; set; }
        private int height { get; set; }
        private ColorModel color { get; set; }
        private int nNobs { get; set; }
        private int blokjeNumber { get; set; }
        private string blokjeImg { get; set; }
        public BlokjeModel(int width, int lenght, int height, ColorModel color, int nNobs, int blokjeNumber, string blokjeImg)
        {
            this.width = width;
            this.lenght = lenght;
            this.height = height;
            this.color = color;
            this.nNobs = nNobs;
            this.blokjeNumber = blokjeNumber;
            this.blokjeImg = blokjeImg;
        }
    }
}
