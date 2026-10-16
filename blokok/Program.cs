using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata;

namespace blokok
{
    internal class Program
    {
        static string[] tompok = new string[7] ;
        static void Torpokletrehozasa()
        {
            tompok[0] = "szundi"; 
            tompok[1] = "szende";
            tompok[2] = "hapci";
            tompok[3] = "morgo";
            tompok[4] = "tudor";
            tompok[5] = "vidor";
            tompok[6] = "kuka";
            Console.WriteLine($"a torpok lista hossza {tompok.Length}");
            for (int i = 0; i < tompok.Length; i++)
            {
                Console.WriteLine(tompok[i]);
            }
        }
        static void Csere()
        {

            Console.WriteLine("melyik törpöt csereljük le ");
            string nev = Console.ReadLine();
            int hanyadik = 8;
            for (int i = 0; i < tompok.Length; i++)
            {
                if (tompok[i] == nev)
                {

                    hanyadik = i;

                }


            }
            if (hanyadik == 8)
            {
                Console.WriteLine("nincs ilyen törpe a listaba ");
            }
            int index = 0;
            while (index < tompok.Length && tompok[index] != nev)
            {
                index += 1;
            }
            if (index < tompok.Length)
            {
                Console.WriteLine("meklik törpöt cseréljük le ");
                string ujnev = Console.ReadLine();
                tompok[index] = ujnev;
                Console.WriteLine("lecserelve");
            }
            else
            {
                Console.WriteLine("nincs ilyen törpe a listában");

            }
        }
        static void Main(string[] args)
        {
            Torpokletrehozasa();
            Csere();
        }
    }
}
