using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormDemo
{
    class Person
    {

        private string navn;

        public string Navn
        {
            get { return navn; }
            set { navn = value; }
        }

   

        private bool erDansk;

        public bool ErDansk
        {
            get { return erDansk; }
            set { erDansk = value; }
        }

        private DateTime fødselsDato;

        public DateTime FødselsDato
        {
            get { return fødselsDato; }
            set { fødselsDato = value; }
        }




    }
}
