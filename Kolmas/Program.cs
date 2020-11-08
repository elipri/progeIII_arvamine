using System;

namespace Kolmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int inimene;
            int arvuti;
            int katsed = 0;
            Random juhus = new Random();
            arvuti = juhus.Next(1, 50);
            Console.WriteLine("Ahoi!");
            Console.WriteLine("Valisin ühe numbri vahemikus 1..50. Mis see on?");
            while (true)
            {
                string sisend = Console.ReadLine();
                if (string.IsNullOrEmpty(sisend))
                    break;
                try
                {
                    inimene = Int32.Parse(sisend);
                } catch
                {
                    katsed++;
                    Console.WriteLine("Aga see ei ole ju täisarv!");
                    Console.WriteLine("Oled teinud {0} katse(t). Proovi veel:", katsed);
                    continue;
                }
                if (inimene == arvuti)
                {
                    katsed++;
                    Console.WriteLine("Tegid {0} katse(t) ja arvasid ära! Jei-juhhuu!", katsed);
                    break;
                }
                else if (inimene > 50 | inimene < 1)
                {
                    katsed++;
                    Console.WriteLine("Arv peab olema vahemikus 1..50!");
                    Console.WriteLine("Tehtud {0} katse(t). Proovi veel:", katsed);
                }
                else if (inimene > arvuti)
                {
                    katsed++;
                    Console.WriteLine("Minu valitud arv on väiksem.");
                    Console.WriteLine("Tehtud {0} katse(t). Proovi veel:", katsed);
                }
                else if (inimene < arvuti)
                {
                    katsed++;
                    Console.WriteLine("Minu valitud arv on suurem.");
                    Console.WriteLine("Tehtud {0} katse(t). Proovi veel:", katsed);
                }
            }
            Console.WriteLine("Mäng läbi. Lehv-lehv.");
        }
    }
}
