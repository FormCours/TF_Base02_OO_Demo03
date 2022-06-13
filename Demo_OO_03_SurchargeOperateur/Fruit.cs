using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_03_SurchargeOperateur
{
    class Fruit
    {
        private double _Poids;

        public string Nom { get; set; }
        public double Poids
        {
            get { return _Poids; }
            set
            {
                if (value > 0)
                {
                    _Poids = value;
                }
                else
                {
                    _Poids = 50;
                }
            }
        }

        public Fruit(string nom, double poids)
        {
            this.Nom = nom;
            this.Poids = poids;
        }
    }
}
