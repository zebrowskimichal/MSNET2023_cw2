using System;

namespace zajecia
{
    class Program
    {
        static void inicjuj()
        {
            Console.WriteLine("MST - Zajęcia z MSNET");
            Console.WriteLine("Temat2: Metody, tablice");
            Console.WriteLine("Grupa K2- sobota 11.03.2023");

        }
        static void koniec_programu()
        {
            Console.WriteLine("Naciśnij dowolny przycisk.");
            Console.ReadKey();
        }
        static void linia()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("=");
            }
        }
        static void autor(string autor)
        {
            Console.WriteLine("Autor: " + autor);
        }
        static int dodawanie()
        {
            return 2 + 3;
        }
        static string dzielenie(double a, double b)
        {
            string wynik;
            if (b == 0)
            {
                Console.WriteLine("Nie możesz dzielić przez zero!");
                return "";
            }
            else
            {
                wynik = "Wynik dzielenia: " + a / b;
                return wynik;
            }
        }
        static string geometria()
        {
            return "Nie podano parametru!";
        }
        static string geometria(int a)
        {
            return "Podano promien koła " + a + ", obwód wynosi: " + 2 * Math.PI * a; ;
        }
        static string geometria(int a, int b)
        {
            if (a == b)
            {
                return "To jest kwadrat o boku: " + a + " Pole= " + Math.Pow(a, 2) + " obwód= " + 4 * a;
            }
            else
            {
                return "To jest prostokąt o bokach a= " + a + " i b= " + b + " Pole= " + a * b + " obwód= " + (2 * a + 2 * b);
            }
        }
        static string geometria(int a, int b, int c)
        {
            if (a == b && b == c)
            {
                return "To jest sześcian o boku: " + a + " Objętość= " + Math.Pow(a, 3);
            }
            else
            {
                return "To jest prostopadłościan o bokach a= " + a + " i b= " + b + " i c= " + c + " Objętość= " + a * b * c;
            }
        }
        static void losowanie()
        {
            linia();
            Random los = new Random();

            Console.Write("Podaj ile wylosować liczb: ");
            int koniec = int.Parse(Console.ReadLine());
            string ujemne = "";
            string dodatnie = "";
            for (int i = 1; i <= koniec; i++)
            {
                int liczba = los.Next(-10, 10);
                Console.Write(liczba + ", ");
                if (liczba < 0)
                    ujemne = ujemne + liczba + ", ";
                else
                    dodatnie += liczba + ", ";
            }
            Console.WriteLine();
            Console.WriteLine("Liczby ujemne: " + ujemne);
            Console.WriteLine("Liczby dodatnie: " + dodatnie);
        }
        static void tablica()
        {
            Random los = new Random();
            Console.WriteLine("Podaj dlugosc tablicy z losowanymi liczbami.");
            int dlugosc = int.Parse(Console.ReadLine());
            int[] tablica = new int[dlugosc];
            Console.WriteLine("Losuje liczby");
            for(int i = 0; i<tablica.Length; i++)
            {
                tablica[i] = los.Next(1,10);
            }
            for(int x = 0; x<tablica.Length; x++)
            {
                Console.WriteLine(tablica[x]);
            }
            Console.WriteLine("________________________________");
            Array.Sort(tablica);
            for (int x = 0; x < tablica.Length; x++)
            {
                Console.WriteLine(tablica[x]);
            }
            Console.WriteLine("________________________________");
            Array.Reverse(tablica);
            for (int x = 0; x < tablica.Length; x++)
            {
                Console.WriteLine(tablica[x]);
            }
        }
        static void srednia_tablica()
        {
            Random los = new Random();
            Console.WriteLine("Podaj dlugosc tablicy z losowanymi liczbami.");
            int dlugosc = int.Parse(Console.ReadLine());
            int[] tablica = new int[dlugosc];
            Console.WriteLine("Losuje liczby");
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = los.Next(1, 10);
            }
            Console.WriteLine("Wylosowalem liczby!");
            int wynikTablica = 0;
            for (int i = 0; i < tablica.Length; i++)
            {
                wynikTablica = wynikTablica + tablica[i];
            }
            Console.WriteLine("Wszystkie liczby z tablicy wynosza: " + wynikTablica);
            int srednia = wynikTablica / tablica.Length;
            int powyzejSredniej = 0;
            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] > srednia)
                {
                    powyzejSredniej += 1;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(tablica[i]);
                } else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(tablica[i]);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Jest " + powyzejSredniej + " liczb powyzej sredniej " + srednia);
        }
        static void roznicaTablica()
        {
            Random los = new Random();
            Console.WriteLine("Podaj dlugosc tablicy z losowanymi liczbami.");
            int dlugosc = int.Parse(Console.ReadLine());
            int[] tablica = new int[dlugosc];
            Console.WriteLine("Losuje liczby");
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = los.Next(1, 10);
            }
            Console.WriteLine("Wylosowalem liczby!");
            int najwiekszaLiczba = 0;
            for (int i = 0; i < tablica.Length; i++)
            {
                if(tablica[i] > najwiekszaLiczba)
                {
                    najwiekszaLiczba = tablica[i];
                }
            }
            Console.WriteLine("Najwieksza liczba wynosi: " + najwiekszaLiczba);
            int najmniejszaLiczba = najwiekszaLiczba;
            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] < najmniejszaLiczba)
                {
                    najmniejszaLiczba = tablica[i];
                }
            }
            Console.WriteLine("Najmniejsza liczba wynosi: " + najmniejszaLiczba);
            int roznica = najwiekszaLiczba - najmniejszaLiczba;
            Console.WriteLine(roznica);
        }


        static void Main(string[] args)
        {
            inicjuj();
            autor("Michal");
            roznicaTablica();
            tablice();
            koniec_programu();
        }
    }
}
