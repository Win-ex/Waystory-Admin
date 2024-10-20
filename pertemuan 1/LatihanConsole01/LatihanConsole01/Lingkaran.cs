using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LatihanConsole01
{
    internal class Lingkaran:IBangunDatar
    {
        public double r { set; get; }
        public double Keliling()
        {
            return 2 * Math.PI * r;
        }
        public double Luas()
        {
            return Math.Sqrt(r * r);
        }
    }
}
