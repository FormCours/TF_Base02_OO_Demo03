using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OO_03_SurchargeOperateur
{
    class Panier
    {
        private List<Fruit> _Fruits;

        /// <summary>
        /// Liste des fruits contenu dans le panier
        /// </summary>
        public IEnumerable<Fruit> Fruits 
        { 
            get { return _Fruits.AsReadOnly(); }
        }

        /// <summary>
        /// Initialise une panier avec une liste de vide
        /// </summary>
        public Panier()
        {
            _Fruits = new List<Fruit>();
        }

        /// <summary>
        /// Méthode pour ajouter un fruit dans le panier
        /// </summary>
        /// <param name="fruit">Un fruit</param>
        public void AjouterFruit(Fruit fruit)
        {
            if(fruit is null)
            {
                return;  // Execption dans le futur :o
            }

            _Fruits.Add(fruit);
        }

        /// <summary>
        /// Addition du contenu de 2 paniers
        /// </summary>
        /// <param name="p1">Panier de gauche</param>
        /// <param name="p2">Panier de droite</param>
        /// <returns>Le panier final</returns>
        public static Panier operator+(Panier p1, Panier p2)
        {
            Panier pTotal = new Panier();

            foreach (Fruit fruit in p1.Fruits)
            {
                pTotal.AjouterFruit(fruit);
            }

            foreach (Fruit fruit in p2.Fruits)
            {
                // On est dans la classe => On a donc acces a la variable privé !
                pTotal._Fruits.Add(fruit);
            }

            return pTotal;
        }
    }
}
