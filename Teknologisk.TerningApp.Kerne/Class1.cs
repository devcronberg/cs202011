using System;

namespace Teknologisk.TerningApp.Kerne
{

    public class Terning {

        private ITilfældighedsGenerator rnd;

        public int Værdi { get; private set; }

        //public Terning()
        //{
        //    rnd = new TilfældighedsGeneratorRandom();
        //    this.Ryst();
        //}

        public Terning(ITilfældighedsGenerator r)
        {
            rnd = r;
            this.Ryst();
        }

        public void Ryst() {
            this.Værdi = rnd.Next(1, 7);
        }

        public string Skriv() {
            return "[ " +  this.Værdi + " ]";
        }
    }

    public interface ITilfældighedsGenerator {
        int Next(int min, int max);
    }

    public class TilfældighedsGeneratorRandom : ITilfældighedsGenerator
    {
        private static Random rnd = new Random();
        public int Next(int min, int max)
        {
            return rnd.Next(min, max);
        }
    }

    public class TilfældighedsGeneratorMock : ITilfældighedsGenerator
    {        
        public int Next(int min, int max)
        {
            return 6;
        }
    }

}
