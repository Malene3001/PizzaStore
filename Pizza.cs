using System;
namespace PizzaStore
{
    public class Pizza
    {
  
            private string _pizzaNavn;
            private double _pizzaPris;
            private int _pizzaNummer;
        //

        public Pizza(string pizzaNavn, double pizzaPris, int pizzaNummer)
            {
                _pizzaNavn = pizzaNavn;
                _pizzaPris = pizzaPris;
                _pizzaNummer = pizzaNummer;
            }
        //

            public string Navn
        {
            get { return _pizzaNavn; }
            set { _pizzaNavn = value; }
        }
        //

            public double Pris
        {
            get { return _pizzaPris; }
            set { _pizzaPris = value; }
        }
        //

            public int Nummer
        {
            get { return _pizzaNummer;  }
            set { _pizzaNummer = value;  }
        }
        //

        public override string ToString()
        {
            return $"Pizzanavn: {Navn} - Pris: {Pris} - Nr.: {Nummer}";
        }
    }
}
