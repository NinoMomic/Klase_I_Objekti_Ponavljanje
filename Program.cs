using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseIobjekti3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stablo stablo1 = new Stablo(true);
            Stablo stablo2 = new Stablo(false);

            Console.WriteLine("Prvo " + stablo1.ToString());
            Console.WriteLine("Drugo " + stablo2.ToString());

            Console.ReadKey();
        }

        class Stablo
        {
            bool otpadajuListovi;
            string vrstaStabla;

            #region set metode
            public void setListovi(bool otpadajuListovi)
            {
                this.otpadajuListovi = otpadajuListovi;
            }
            public void setVrsta(string vrstaStabla)
            {
                this.vrstaStabla = vrstaStabla;
            }
            #endregion

            #region set metode
            public bool getListovi()
            {
                return this.otpadajuListovi;
            }
            public string getVrsta()
            {
                return this.vrstaStabla;
            }

            #endregion

            public Stablo(bool otpadajuListovi)
            {
                this.otpadajuListovi = otpadajuListovi;


            }

            public override string ToString()
            {
                string ispis = null;
                switch (this.otpadajuListovi)
                {
                    case true:
                        ispis = "stablo je bijelogorično";
                        break;

                    case false:
                        ispis = "stablo je crnogorično";
                        break;

                }
                return ispis;
            }

        }
    }
}
