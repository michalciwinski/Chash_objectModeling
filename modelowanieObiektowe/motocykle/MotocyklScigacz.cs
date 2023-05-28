using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelowanieObiektowe
{
    public class MotocyklScigacz : Motocykl
    {
        private int MaxPredkosc;
        private int CzasDoSetki;

        public void UstawMaxPredkosc(int maxpredkosc)
        {
            if (maxpredkosc > 300)
            {
                MaxPredkosc = 300;
            }
            else
            {
                MaxPredkosc = maxpredkosc;
            }
        }
        public int _MaxPredkosc
        {
            get { return MaxPredkosc; }
        }
        public int _CzasDoSetki
        {
            get { return CzasDoSetki; }
            set { CzasDoSetki = value; }
        }

        public MotocyklScigacz(string NrRejestracyjyny, bool CzyZepsuty, string Vin, int Moc, int MaxPredkosc, int CzasDoSetki)
        {
            this.RodzajMotocyklu = "Scigacz";
            this.NrRejestracyjyny = NrRejestracyjyny;
            this.CzyZepsuty = CzyZepsuty;
            this.Vin = Vin;
            this._Moc = Moc;
            UstawMaxPredkosc(MaxPredkosc);
            this.CzasDoSetki = CzasDoSetki;
        }

        public void odcina()
        {
            if (_CzyZepsuty == false)
            {
                Console.WriteLine("Łutututututututuuuuuu");
            }
            else
            {
                Console.WriteLine("Scigacz jest zepusty.");
            }
            
        }

        public override void szczegolyMotocykl()
        {
            Console.WriteLine($"Vin:{_Vin}, Rodzaj:{_RodzajMotocyklu}, Rejestracja:{_NrRejestracyjyny}, Stan:{_CzyZepsuty}, Moc:{_Moc}, MaxPred:{_MaxPredkosc}, CzasDoSetki:{_CzasDoSetki}");
        }

    }
}
