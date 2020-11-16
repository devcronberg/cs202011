using System;
using System.Collections.Generic;
using System.Text;

namespace Indkapsling
{
    class Hund
    {

        private string navn;

        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }

        private int _antalBen;

        public int AntalBen
        {
            get { return _antalBen; }
            set {                _antalBen = value; }
        }


    }


    class Bil {
        private int _motor;

        public int Motor
        {
            get { 
                
                return _motor; }
            set { 
                
                _motor = value; }
        }

    }

}
