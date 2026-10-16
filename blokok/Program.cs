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
        static void Main(string[] args)
        {
            Torpokletrehozasa();

        }
    }
}
