using System;
namespace PizzaStore
{
    //Deklaration

    public class Kunde
    {

    //Instantiering

        private string _kundeNavn;
        private int _kundeNr;

    //Konstruktion

        public Kunde(string kundeNavn, int kundeNr)
        {
            _kundeNavn = kundeNavn;
            _kundeNr = kundeNr;
        }

    //Properties

        public string KundeNavn
        {
            get { return _kundeNavn; }
            set { _kundeNavn = value; }
        }

        //

        public int KundeNr
        {
            get { return _kundeNr; }
            set { _kundeNr = value; }
        }

     //Metode

        public override string ToString()
        {
            return $"Kundenavn: {KundeNavn} KundeNr: {KundeNr}";
        }

    }
    
}
