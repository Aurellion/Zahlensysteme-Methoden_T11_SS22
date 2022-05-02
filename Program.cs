using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlensysteme_Methoden_T11_SS22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menu:
            string nochmal = "j";
            string auswahl = "";
            do
            {
                Console.WriteLine("Zahlensysteme:");
                Console.WriteLine("1: Umwandlung von dezimal zu binär.");
                Console.WriteLine("2: Umwandlung von binär zu dezimal.");
                Console.WriteLine("3: Umwandlung von dezimal zu hexadezimal.");
                Console.WriteLine("4: Umwandlung von hexadezimal zu dezimal.");
                Console.Write("Auswahl:");
                auswahl = Console.ReadLine();
                int dezimaleingabe;
                switch (auswahl)
                {
                        case "1":
                        Console.Write("Dezimalzahl eingeben:");
                        dezimaleingabe = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("[" + dezimaleingabe + "]_10 = [" + DezimalZuBinär(dezimaleingabe) + "]_2");
                        break;
                    case "2":
                        Console.Write("Binärzahl eingeben:");
                        string binäreingabe = Console.ReadLine();
                        Console.WriteLine("[" + binäreingabe + "]_2 = [" + BinärZuDezimal(binäreingabe) + "]_10");
                        break;
                    case "3":
                        Console.Write("Dezimalzahl eingeben:");
                        dezimaleingabe = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("[" + dezimaleingabe + "]_10 = [" + DezimalZuHexadezimal(dezimaleingabe) + "]_16");
                        break;
                    case "4":
                        Console.Write("Hexadezimalzahl eingeben:");
                        string hexaleingabe = Console.ReadLine();
                        int ausgabe = HexadezimalZuDezimal(hexaleingabe);
                        Console.WriteLine("[" + hexaleingabe + "]_16 = [" + ausgabe + "]_10");
                        break;
                    default:
                        Console.WriteLine("ungültige Auswahl");
                        break;

                }
            } while (nochmal == "j" || nochmal == "J");

            

            
        }

        static int BinärZuDezimal(string binärzahl)
        {
            int dezimalzahl=0;
            for (int i = 0; i < binärzahl.Length; i++)
            {
                int l = binärzahl.Length;
                int intBinär = Convert.ToInt32(binärzahl[i].ToString());
                dezimalzahl += intBinär * (int)Math.Pow(2, l-1-i);
            }
            return dezimalzahl;
        }

        static string DezimalZuBinär(int dezimalzahl)
        {
            string binärzahl = "";
            int Rest;
            int Quotient = dezimalzahl;
            while (Quotient != 0)
            {
                Rest = Quotient % 2;
                Quotient /= 2;// Quotient = Quotient / 2;
                binärzahl = Rest + binärzahl;//Konkatenation ist nicht kommutativ: rest + binärzahl != binärzahl + rest
            }
            return binärzahl;
        }

        static int BuchstabeZuZahl(string buchstabe)
        {
            int zahl;
            
                switch (buchstabe.ToUpper())//Umwandlung in Großbuchstaben
                {
                    case "A":
                        zahl = 10;
                        break;
                    case "B":
                        zahl = 11;
                        break;
                    case "C":
                        zahl = 12;
                        break;
                    case "D":
                        zahl = 13;
                        break;
                    case "E":
                        zahl = 14;
                        break;
                    case "F":
                        zahl = 15;
                        break;
                    default:
                    zahl = Convert.ToInt32(buchstabe);
                        break;
                }
                    
            return zahl;
        }

        static string ZahlZuBuchstabe(int zahl)
        {
            string buchstabe;
            if(zahl < 10)
            {
                buchstabe = zahl.ToString();
            }
            else
            {
                switch (zahl)
                {
                    case 10:
                        buchstabe = "A";
                        break;
                    case 11:
                        buchstabe = "B";
                        break;
                    case 12:
                        buchstabe = "C";
                        break;
                    case 13:
                        buchstabe = "D";
                        break;
                    case 14:
                        buchstabe = "E";
                        break;
                    case 15:
                        buchstabe = "F";
                        break;
                    default:
                        buchstabe = "X";
                        break;
                }
            }
            return buchstabe;
        }

        static string DezimalZuHexadezimal(int dezimalzahl)
        {
            string hexadezimalzahl = "";
            int Rest;
            int Quotient = dezimalzahl;
            while (Quotient != 0)
            {
                Rest = Quotient % 16;
                Quotient /= 16;// Quotient = Quotient / 16;
                hexadezimalzahl = ZahlZuBuchstabe(Rest) + hexadezimalzahl;//Konkatenation ist nicht kommutativ: rest + binärzahl != binärzahl + rest
            }
            return hexadezimalzahl;
        }

        static int HexadezimalZuDezimal(string hexadezimalzahl)
        {
            int dezimalzahl = 0;
            for (int i = 0; i < hexadezimalzahl.Length; i++)
            {
                int l = hexadezimalzahl.Length;
                int stelle = BuchstabeZuZahl(hexadezimalzahl[i].ToString());                
                int intHexal = Convert.ToInt32(stelle);
                dezimalzahl += intHexal * (int)Math.Pow(16, l - 1 - i);
            }
            return dezimalzahl;
        }

    }
}
