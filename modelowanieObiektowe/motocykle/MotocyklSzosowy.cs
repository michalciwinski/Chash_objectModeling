using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelowanieObiektowe
{
    public class MotocyklSzosowy : Motocykl
    {
        private int IloscPaliwa;
        private int SpalanieSrednie;
        public int _IloscPaliwa
        {
            get { return IloscPaliwa; }
            set { IloscPaliwa = value; }
        }
        public int _SpalanieSrednie
        {
            get { return SpalanieSrednie; }
            set { SpalanieSrednie = value; }
        }
        public MotocyklSzosowy(string NrRejestracyjyny, bool CzyZepsuty, string Vin, int Moc, int IloscPaliwa, int SpalanieSrednie)
        {
            this._RodzajMotocyklu = "Szosowy";
            this.NrRejestracyjyny = NrRejestracyjyny;
            this.CzyZepsuty = CzyZepsuty;
            this.Vin = Vin;
            this._Moc = Moc;
            this.IloscPaliwa = IloscPaliwa;
            this.SpalanieSrednie = SpalanieSrednie;
        }
        public override void szczegolyMotocykl()
        {
            Console.WriteLine($"Vin:{_Vin}, Rodzaj:{_RodzajMotocyklu}, Rejestracja:{_NrRejestracyjyny}, Stan:{_CzyZepsuty}, Moc:{_Moc}, Paliwo:{_IloscPaliwa}, Spalanie:{_SpalanieSrednie}");
        }
        public void tankowanie(int ileLitrow)
        {
            _IloscPaliwa = _IloscPaliwa + ileLitrow;
        }
        public void obliczZasieg()
        {
            Console.WriteLine($"Zasieg km wynosi: {(float)_IloscPaliwa/ (float)_SpalanieSrednie * 100}");
        }
        public void spuscPaliwo()
        {
            Console.WriteLine("Spuszczam nadmiar paliwa przed sprzedaza.");
            _IloscPaliwa = 0;
        }
        ~MotocyklSzosowy()
        {
            spuscPaliwo();
        }

    }
}
