using System;
namespace PizzaStore
{
    public class Butik
    {
       
            public void Start()
            {

            //Tildeling

             //Pizza
                Pizza p1 = new Pizza("Margherita", 69, 1);
                Pizza p2 = new Pizza("Gorgonzola", 85, 9);
                Pizza p3 = new Pizza("Capricciosa", 80, 3);

            //Kunde
                Kunde k1 = new Kunde("Luca", 1);
                Kunde k2 = new Kunde("Giovanni", 2);
                Kunde k3 = new Kunde("Mauro", 3);

            //Bestilling
            Bestilling o1 = new Bestilling(p1, k1);
            Bestilling o2 = new Bestilling(p2, k2);
            Bestilling o3 = new Bestilling(p3, k3);

            //Udskrift
            Console.WriteLine();
            Console.WriteLine(o1);
            Console.WriteLine();
            Console.WriteLine(o2);
            Console.WriteLine();
            Console.WriteLine(o3);
            Console.WriteLine();

        }

    }
}
