using System.Diagnostics.Tracing;

namespace Tombok
{
    internal class Program
    {
        static string[] torpok = new string[7];
        static void TorpokLetrehozasa()
        {
            torpok[0] = "Torpok 1";
            torpok[1] = "Torpok 2";
            torpok[2] = "Torpok 3";
            torpok[3] = "Torpok 4";
            torpok[4] = "Torpok 5";
            torpok[5] = "Torpok 6";
            torpok[6] = "Torpok 7";
        }

        static void TorpokKiirasa()
        {
            Console.WriteLine($"A torpok lista elemei:");
            for (int i = 0; i < torpok.Length; i++)
            {
                Console.WriteLine(torpok[i]);
            }
        }

        static void Csere()
        {
            Console.WriteLine("Melyik törpöt cseráljük:");
            string nev = Console.ReadLine();
            
            
            int index = 0;
            while (index < torpok.Length && torpok[index] != nev)
            {
                index++;
            }
            if (index < torpok.Length)
            {
                Console.WriteLine("Melyik törpe cseréljük le?");
                string ujNev = Console.ReadLine();
                torpok[index] = ujNev;
                Console.WriteLine("Lecserélve");
            }
            else
            {
                Console.WriteLine("Nincs ilyen törp");
            }
        }

        static void Main(string[] args)
        {
            TorpokLetrehozasa();
            TorpokKiirasa();
            Csere();
        }
    }
}
