using System;
using System.Collections.Generic;

namespace modelowanieObiektowe
{
    class Program
    {
        static void Main(string[] args)
        {

            Garaż GMokotowska = new Garaż("Mokotowska 23");
            GMokotowska.IleMotocykli();
            //zakup pierwszego motocyklu
            GMokotowska.DodajMotocykl("Szosowy", "WPR 6666", true, "123456789", 180);
            GMokotowska.IleMotocykli();
            Console.WriteLine(" ");
            //zakup drugiego motocyklu
            GMokotowska.DodajMotocykl("Scigacz", "WPR 7777", false, "987654321", 280);
            GMokotowska.IleMotocykli();
            GMokotowska.SzczegolyStajnii();
            Console.WriteLine(" ");
            //sprzedaz pierwszego
            GMokotowska.UsunMotocykl("123456789");
            GMokotowska.IleMotocykli();
            GMokotowska.SzczegolyStajnii();
            Console.WriteLine(" ");

            //dodanie motocyklu jako wywolanie alternatywnego konstrukturoa czyli motoru o nieznanych parametrach
            GMokotowska.DodajMotocyklNieznany();
            GMokotowska.IleMotocykli();
            GMokotowska.SzczegolyStajnii();
            Console.WriteLine(" ");

            //dodanie motycklu szosowego 
            GMokotowska.DodajMotocyklSzosowy("WPR 5555", false, "675894752", 150, 20, 6);
            GMokotowska.IleMotocykli();
            GMokotowska.SzczegolyStajnii();
            Console.WriteLine(" ");

            //dodanie motycklu scigacz
            GMokotowska.DodajMotocyklScigacz("WPR 6857", false, "435624567", 300, 280, 5);
            GMokotowska.IleMotocykli();
            GMokotowska.SzczegolyStajnii();
            Console.WriteLine(" ");

            Console.WriteLine("------------------------------------------------------------");

            //zwiekszenie mocy jednego z motocykli
            Motocykl motocyklDoChipowania = GMokotowska.MotocyklLista.Find(m => m._Vin == "435624567");
            Console.WriteLine(motocyklDoChipowania._Moc);
            motocyklDoChipowania.chipTuning(20);
            Console.WriteLine(motocyklDoChipowania._Moc);

            //uruchomienie odciny oraz zwiekszenie maksymalnej predkosci dla scigacza
            MotocyklScigacz scigacz = (MotocyklScigacz)motocyklDoChipowania; //rzutowanie zwyklego motocyklu na
                                                                             //klase pochodna
            Console.WriteLine(scigacz._MaxPredkosc);
            scigacz.UstawMaxPredkosc(300);
            Console.WriteLine(scigacz._MaxPredkosc);
            scigacz.odcina();

            //tankowanie, oblzasiegu, spuszczeniepaliwa
            Motocykl motocyklSzosowy = GMokotowska.MotocyklLista.Find(m => m._Vin == "675894752");
            MotocyklSzosowy motocyklSzosowyRzut = (MotocyklSzosowy)motocyklSzosowy;
            Console.WriteLine(motocyklSzosowyRzut._IloscPaliwa);
            motocyklSzosowyRzut.tankowanie(25);
            Console.WriteLine(motocyklSzosowyRzut._IloscPaliwa);
            motocyklSzosowyRzut.obliczZasieg();
            motocyklSzosowyRzut.spuscPaliwo();
            Console.WriteLine(motocyklSzosowyRzut._IloscPaliwa);

            //uzycie referencji jako podobnego mechanizmu jak wskazniki w c++
            RefMotocyklScigacz(ref scigacz);
        }
        public static void RefMotocyklScigacz(ref MotocyklScigacz motocykl)
        {
            motocykl.szczegolyMotocykl(); // Wywołanie metody z klasy MotocyklScigacz przez referencję
        }
    }
}
