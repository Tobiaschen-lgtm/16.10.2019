using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._10._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menü");
            int auswahl;
            string wiederholung;
            Console.WriteLine("1: Dezimal zu Binär");
            Console.WriteLine("2: Binär zu Dezimal");
            Console.WriteLine("3: Dezimal in Hexadezimal");
            Console.WriteLine("4: Hexadezimal in Dezimal");
            Console.WriteLine("Aktion auswählen");
            auswahl = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (auswahl == 1)
                {
                    string eingabe, ausgabe;

                    Console.WriteLine("Dezimalzahl eingeben");
                    eingabe = Console.ReadLine();
                    ausgabe = Von10zu2(eingabe);



                    string ausgabe_R = "";
                    for (int i = ausgabe.Length - 1; i >= 0; i--)
                    {
                        ausgabe_R += ausgabe[i];

                    }
                    Console.WriteLine(eingabe + " in bäner: " + spieglen(ausgabe));
                }
                else if (auswahl == 2)
                {
                    string eingabe;
                    double dez = 0;
                    Console.WriteLine("Binärzahl:");
                    eingabe = Console.ReadLine();

                    for (int i = 0; i < eingabe.Length; i++)
                    {

                        double faktor = Convert.ToDouble(Convert.ToString(eingabe[i]));
                        double exponent = Convert.ToDouble(eingabe.Length - 1 - i);

                        dez += faktor * Math.Pow(2, exponent);
                    }
                    Console.WriteLine(eingabe + " in dezimal " + dez);
                }
                else if (auswahl == 3)
                {
                    string eingabe, ausgabe;

                    Console.WriteLine("Dezimalzahl eingeben");
                    eingabe = Console.ReadLine();
                    ausgabe = Von10zu16(eingabe);
                    Console.WriteLine(eingabe + "in Hexadezimal" + ausgabe);
                }
                else if (auswahl == 4)
                {
                    string eingabe, ausgabe;

                    Console.WriteLine("Hexadezimal eingeben");
                    eingabe = Console.ReadLine();
                    ausgabe = Von10zu16(eingabe);
                    Console.WriteLine(eingabe + "in Dezimal" + ausgabe);
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe.");
                }

                Console.WriteLine("neue Aktion wählen? (j/n)");
                wiederholung = Console.ReadLine();


            } while (wiederholung == "j");
        }

        static string spieglen(string input)
        {
            string ausgabe_R = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                ausgabe_R += input[i];

            }

            return ausgabe_R;
        }

        static string Von10zu2(string input)
        {
            int dez, quo, rest;
            dez = Convert.ToInt32(input);
            quo = 1;
            string ausgabe = "";
            while (quo != 0)
            {
                quo = dez / 2;
                rest = dez % 2;
                ausgabe += Convert.ToString(rest);
                dez = quo;
            }
            return ausgabe;

        }
        static string Von10zu16(string input)
        {
            int dez, quo, rest;
            dez = Convert.ToInt32(input);
            quo = 1;
            string ausgabe = "";
            while (quo != 0)
            {
                quo = dez / 16;
                rest = dez % 16;//%取余数
                ausgabe += ZahlzuBuchstabe(rest);
                dez = quo;
            }
            return ausgabe;
        }
        static string ZahlzuBuchstabe(int Zahl)
        {
            if (Zahl == 10) return "A";
            else if (Zahl == 11) return "B";
            else if (Zahl == 12) return "C";
            else if (Zahl == 13) return "D";
            else if (Zahl == 14) return "E";
            else if (Zahl == 15) return "F";
            else return Convert.ToString(Zahl);
        }
        static string Von16zu10(string input)
        {
            for (int i = 0; i < input.Length; i++);
            {
                double faktor = BuchstabeZuZahl(Convert.ToString(input[i]));
                double exponent 
            }
            return ausgabe;

        }
    }
}