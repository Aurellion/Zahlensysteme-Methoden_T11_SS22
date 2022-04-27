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
            Console.Write("Binärzahl eingeben:");
            string binäreingabe = Console.ReadLine();
            Console.WriteLine("["+binäreingabe+"]_2 = [" +BinärZuDezimal(binäreingabe)+"]_10");

            Console.Write("Dezimalzahl eingeben:");
            int dezimaleingabe = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("["+dezimaleingabe+"]_10 = ["+DezimalZuBinär(dezimaleingabe)+"]_2");
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
    }
}
