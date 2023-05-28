using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelowanieObiektowe
{
    public class Garaż
    {
        private string Adres;
        private int IloscPojazdow;
        public List<Motocykl> MotocyklLista;
        public int _IloscPojazdow
        {
            get { return IloscPojazdow; }
            //set { IloscPojazdow = value; }
        }
        public string _Adres
        {
            get { return Adres; }
        }
        public Garaż(string Adres)
        {
            this.Adres = Adres;
            MotocyklLista = new List<Motocykl>();
        }
        public void DodajMotocykl(string RodzajMotocyklu, string NrRejestracyjyny, bool CzyZepsuty, string Vin, int Moc)
        {
            Motocykl motocykl = new Motocykl(RodzajMotocyklu, NrRejestracyjyny, CzyZepsuty, Vin, Moc);
            MotocyklLista.Add(motocykl);
        }
        public void DodajMotocyklNieznany()
        {
            Motocykl motocykl = new Motocykl();
            MotocyklLista.Add(motocykl);
            this.IloscPojazdow++;
        }
        public void DodajMotocyklScigacz(string NrRejestracyjyny, bool CzyZepsuty, string Vin, int Moc, int MaxPredkosc, int CzasDoSetki)
        {
            MotocyklScigacz motocykl = new MotocyklScigacz( NrRejestracyjyny, CzyZepsuty, Vin, Moc, MaxPredkosc, CzasDoSetki);
            MotocyklLista.Add(motocykl);
        }
        public void DodajMotocyklSzosowy(string NrRejestracyjyny, bool CzyZepsuty, string Vin, int Moc, int IloscPaliwa, int SpalanieSrednie)
        {
            MotocyklSzosowy motocykl = new MotocyklSzosowy(NrRejestracyjyny, CzyZepsuty, Vin, Moc, IloscPaliwa, SpalanieSrednie);
            MotocyklLista.Add(motocykl);
        }
        public void UsunMotocykl(string Vin)
        {
            int i = 0;
            int indeks = 0;
            foreach (var moto in this.MotocyklLista)
            {
                if(moto._Vin == Vin)
                {
                    indeks = i;
                }
                i++;
            }
            MotocyklLista.RemoveAt(indeks);
            IloscPojazdow--;
        }

        public void IleMotocykli()
        {
            Console.WriteLine("Liczba mototyckli w garazu: {0}", MotocyklLista.Count);
        }
        public void SzczegolyStajnii()
        {

            foreach (var moto in this.MotocyklLista)
            {
                moto.szczegolyMotocykl();
            }

        }
    }
}
