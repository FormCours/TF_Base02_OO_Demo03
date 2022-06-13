using System;
using System.Collections.Generic;

namespace Demo_OO_03_SurchargeOperateur
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit f1 = new Fruit("Pomme Rouge", 100);
            Fruit f2 = new Fruit("Pomme Verte", 150);
            Fruit f3 = new Fruit("Cerise", 15);
            Fruit f4 = new Fruit("Fraise", 20);

            Panier panier1 = new Panier();
            panier1.AjouterFruit(f1);
            panier1.AjouterFruit(f2);

            Panier panier2 = new Panier();
            panier2.AjouterFruit(f3);
            panier2.AjouterFruit(f4);

            Panier panier3 = new Panier();
            panier3.AjouterFruit(new Fruit("Tomate", 90));

            Panier panierFinal = panier1 + panier2 + panier3;

            Console.WriteLine("Liste des fruits");
            foreach (Fruit fruit in panierFinal.Fruits)
            {
                Console.WriteLine($" - {fruit.Nom} {fruit.Poids}gr");
            }

            // TODO Finir la demo
            Console.WriteLine();
        }
    }
}
