using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr1_Lekcja2_2023_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kartoteka pacjenta

            //  TYP nazwa = wartość;

            // string - typ tekstowy 
            // char - typ znakowy - tylko pojedyncze znaki

            // int - typ liczbowy - liczby całkowite
            // double - typ liczbowy - liczby z ułamkami
            // float - typ liczbowy - liczby z ułamkami (mniej dokładny)
            // decimal - typ liczbowy - liczby z ułamkami (bardzo dokładny, np. do walut)

            // bool - typ logiczny - true, false

            string imie = "Kamil";
            string nazwisko = "Nowak";
            string dataUrodzenia = "24-10-1998";
            string objawy = "Pacjenta kaszle oraz ma katar";
            string historiaChorób = "angina, covid19";
            string pesel = "1445322353";
            string alergie = "sierść kota";
            double waga = 80.6;
            int wzrost = 172;
            char plec = 'k';
            bool czyOsobaPalaca = false;

            Console.WriteLine("KARTA PACJENTA");
            Console.WriteLine("Imię: " + imie);
            Console.WriteLine("Nazwisko: " + nazwisko);
            Console.WriteLine("Data urodzenia: " + dataUrodzenia);
            Console.WriteLine("Objawy: " + objawy);
            Console.WriteLine("Historia chorób: " + historiaChorób);
            Console.WriteLine("Pesel: " + pesel);
            Console.WriteLine("Alergie: " + alergie);
            Console.WriteLine("Waga: " + waga + "kg");
            Console.WriteLine("Wzrost: " + wzrost + "cm");
            Console.WriteLine("Płeć: " + plec);
            Console.WriteLine("Czy osoba pali: " + czyOsobaPalaca);

            string ulubionaPiosenka = "Imagine Dragons Thunder";
            string ulubionaPotrawa = "Lasagne";
            char pierwszaLiteraNazwiska = 'S';
            bool czyUzywaKomunikacjiMiejskiej = true;

            //wartość zmiennych można zmieniać!!!
            ulubionaPotrawa = "Rosół";
            Console.WriteLine(ulubionaPotrawa);

            // STAŁE  - stałych nie wilno zmieniać!!!
            // const TYP nazwa = wartość;

            const double PI = 3.14;
            Console.WriteLine(PI);

            //sposoby wypisywania - są jeszcze 2 dodatkowe

            Console.ReadLine();
        }
    }
}
