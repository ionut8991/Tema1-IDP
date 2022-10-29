using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tema1_IDP
{
     class Program
    {
        static void Main(string[] args)
        {
            Carte[] s_arr = Carte.PreiaCarti();
            //Cerinta 1
            
            Console.WriteLine("Introduceti numele cartii pe care doriti sa o cautati: ");
            string s1 = Console.ReadLine();
            try
            {
                List<Carte> c1 = s_arr.Where(c => c.NumeCarte.Contains(s1)).ToList();
                Carte.AfisareCarti(c1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cartea cautata nu se afla in lista.");
            }

            //Cerinta 2

            Console.WriteLine("Introduceti anul de aparitie dorit: ");
            int an = Convert.ToInt32(Console.ReadLine());
           
            List<Carte> c2 = s_arr.Where(c => c.Aparitie == an).ToList();
            Console.WriteLine("Numarul de carti care au aparut in anul respectiv este: " + c2.Count);


            //Cerinta 3

            Console.WriteLine("Introduceti ISBN-ul dorit: ");
            int isbn = Convert.ToInt32(Console.ReadLine());
            List<Carte> c3 = new List<Carte>();
            foreach (Carte c in s_arr)
            {
                string ex_isbn = c.ISBN.ToString();
                string exx_isbn = isbn.ToString();
                if(ex_isbn.StartsWith(exx_isbn))
                {
                    c3.Add(c);
                }
            }
            Carte.AfisareCarti(c3);
            

            //Cerinta 4

            try { 
            Carte c4 = (Carte)s_arr.Where(c => c.Aparitie == 2020 && (c.Editura == "Humanitas"));
                Console.WriteLine("\n Cartile care au aparut in anul 2020 si sunt publicate de editura Humanitas sunt: \n" + c4.NumeCarte);
            }
            catch
            {
                Console.WriteLine("\n Nu exista carti care au aparut in anul 2020 si sunt publicate de editura Humanitas");
            }
            
            //Cerinta 5
            Console.WriteLine("\n Cartile ordonate crescator dupa nume: \n");
            List<Carte> c5 = s_arr.OrderBy(c => c.NumeCarte).ToList();
            Carte.AfisareCarti(c5);

            //Cerinta 6
            Console.WriteLine("\n Cartile ordonate descrescator dupa anul aparitiei: \n");
            List<Carte> c6 = s_arr.OrderByDescending(c => c.Aparitie).ToList();
            Carte.AfisareCarti(c6);

            //Cerinta 7
            Console.WriteLine("\n Cartile care apartin editurilor Teora si Humanitas: \n");
            List<Carte> c7 = s_arr.Where(c => c.Editura == "Teora" || c.Editura == "Humanitas").ToList();
            Carte.AfisareCarti(c7);

            //Cerinta 8
            bool b1 = s_arr.All(c => c.Aparitie > 2020);
            Console.WriteLine("\nToate cartile" + (b1? " au" : " nu au") + " aparut dupa anul 2020");

            //Cerinta 9
            Console.WriteLine("\nLista in care numele cartilor contin cuvantul copil: \n");
            List<Carte> c9 = s_arr.Where(c => c.NumeCarte.Contains("copil")).ToList();
            Carte.AfisareCarti(c9);
        }
    }
}
