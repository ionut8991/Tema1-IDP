using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_IDP
{
     class Carte
    {
        public string NumeCarte;
        public long ISBN;
        public double pret;
        public int Aparitie;
        public string Editura;

        public static Carte[] PreiaCarti()
        {
            Carte[] s_arr =
            {
                new Carte() {NumeCarte="Trei", Editura="Litera", Aparitie = 2022 , ISBN= 9786063395369 , pret = 69.90 },
                new Carte() {NumeCarte="Arta de a citi oamenii", Editura="Litera", Aparitie = 2022  , ISBN= 9786063394911 , pret = 64.90 },
                new Carte() {NumeCarte="Prima luna de razboi. Cronica evenimentelor", Editura="Humanitas", Aparitie = 2020  , ISBN= 9789735076542  , pret = 49.90 },
                new Carte() {NumeCarte="Fizica povestita", Editura="Humanitas", Aparitie = 2022  , ISBN= 9789735076559 , pret = 119.00 },
                new Carte() {NumeCarte="Armata nu se implica in conflict", Editura="Univers", Aparitie = 2020 , ISBN= 9789975319294 , pret = 25.00 },
                new Carte() {NumeCarte="Evreii", Editura="Prut", Aparitie = 2020 , ISBN= 9789975545150 , pret = 40.00},
                new Carte() {NumeCarte="Teoria haosului", Editura="Liberalis", Aparitie = 2020 , ISBN= 9786069488812 , pret = 25.00},
                new Carte() {NumeCarte="Nascut in Zodia mortii", Editura="Andreas", Aparitie = 2017 , ISBN= 9786067650334 , pret = 28.00 },
                new Carte() {NumeCarte="Actiunea interioara", Editura="Paralela 45", Aparitie = 1999 , ISBN= 9789739433945 , pret = 13.00},
                new Carte() {NumeCarte="Retelele Infinitului", Editura="RAO", Aparitie = 1998 , ISBN= 9789739862660 , pret = 19.99},
            };
            return s_arr;
        }
        public static void AfisareCarti(List<Carte>carti)
        {
            foreach (Carte c in carti)
                Console.WriteLine(c.NumeCarte + ", publicata de Editura " + c.Editura + " in anul " + c.Aparitie + ". ISBN:" + c.ISBN + ". Pret: " + c.pret + "RON");
        }
    }
}
