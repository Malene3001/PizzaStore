using System;
namespace PizzaStore
{
    public class Bestilling
    {
        private double levering;
        public Pizza p;
        public Kunde k;

        public Bestilling(Pizza pizza, Kunde kunde)
        {
            p = pizza;
            k = kunde;
            Levering = 40.0;
        }

        double Levering
        {
            get { return levering; }
            set { levering = value; }
        }

        double Pris
        {
            get { return Pris; }
            set { Pris = value; }
        }

        public override string ToString()
        {
            return $"# {k.KundeNr} \tKunde: {k.KundeNavn} " +
                $"\nPizzanr.: {p.Nummer} \tPizza: {p.Navn} \n" +
                $"Pizzapris: {p.Pris} \nLevering: {Levering}  \n" +
                $"Total: {TotalPris()}";
        }

        public double TotalPris()
        {
            return p.Pris + Levering;
        }

    }
}