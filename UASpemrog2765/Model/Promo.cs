using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace UASpemrog2765.Model
{
    public class Promo
    {
        public string promo { get; set; }
        public double potongan { get; set; }

        public Promo(string promo, double potongan)
        {
            this.promo = promo;
            this.potongan = potongan;  
        }


    }
}
