using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanConsole01
{
    internal class PersegiPanjang : IBangunDatar
    {
        //properties
        public double Panjang { get; set; }
        public double Lebar { get; set; }

        //constructor
        public PersegiPanjang(double panjang, double lebar) 
        {
            this.Panjang = panjang; this.Lebar = lebar;
        }

        //method
        public double Keliling()
        {
            return 2 * (Panjang + Lebar);
        }
        public double Luas()
        {
            return Panjang*Lebar;
        }
    }
}
