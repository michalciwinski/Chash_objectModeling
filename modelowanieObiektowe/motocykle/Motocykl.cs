using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelowanieObiektowe
{
    public class Motocykl 
    {
        protected int Moc;
        protected string Vin;
        protected string NrRejestracyjyny;
        protected string RodzajMotocyklu;
        protected bool CzyZepsuty;
        public int _Moc
        {
            get{ return Moc;}
            set{ Moc = value;}
        }
        public string _Vin
        {
            get { return Vin; }
        }
        public string _NrRejestracyjyny
        {
            get { return NrRejestracyjyny; }
            set { NrRejestracyjyny = value; }
        }
        public string _RodzajMotocyklu
        {
            get { return RodzajMotocyklu; }
            set { RodzajMotocyklu = value; }
        }
        public bool _CzyZepsuty
        {
            get { return CzyZepsuty; }
            set { CzyZepsuty = value; }
        }
        //konstruktor główny (PRZECIĄŻENIE NR 1)
        public Motocykl(string RodzajMotocyklu,string NrRejestracyjyny,bool CzyZepsuty, string Vin, int Moc)
        {
            this.RodzajMotocyklu = RodzajMotocyklu;
            this.NrRejestracyjyny = NrRejestracyjyny;
            this.CzyZepsuty = CzyZepsuty;
            this.Vin = Vin;
            this.Moc = Moc;
        }

        //konstruktor alternatywny (PRZECIĄŻENIE NR 2)
        public Motocykl()
        {
            RodzajMotocyklu = "brak danych";
            NrRejestracyjyny = "brak danych";
            CzyZepsuty = true;
            Vin = "brak danych";
            Moc = 0;
        }
        //pokaz szczegoly motocyklu
        public virtual void szczegolyMotocykl()
        {
            Console.WriteLine($"Vin:{_Vin}, Rodzaj:{_RodzajMotocyklu}, Rejestracja:{_NrRejestracyjyny}, Stan:{_CzyZepsuty}, Moc:{_Moc}");
        }

        public void chipTuning(int OIle)
        {
            Moc = Moc + OIle;
        }
        

    }
}
