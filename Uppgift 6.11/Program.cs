using System;
namespace uppgift6_11
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Programmet kommer att rita ut en rektangel.");
                Console.WriteLine();
                Console.Write("Bestäm antal rader och kolumner: ");
                int rader = int.Parse(Console.ReadLine());
                Console.Write("Bestäm tecknet: ");
                char tecken = char.Parse(Console.ReadLine());
                Console.Write("Bestäm antal mellanrum, lämna tom om du inte vill ha mellanrum: ");
                bool svar = int.TryParse(Console.ReadLine(), out int mellanrum);
                if (!svar)
                {
                    mellanrum = 0;
                }
                Console.WriteLine();
                RitaKvadrat(rader, tecken, mellanrum);
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void RitaKvadrat(int rader, char tecken, int mellanrum)
        {
            for (int i = 0; i < rader; i++)
            {
                for (int j = 0; j < rader; j++)
                {
                    Console.Write(tecken);
                    for (int k = 0; k < mellanrum; k++)
                    {
                        Console.Write(" ");
                    }
                }
                for (int k = 0; k < mellanrum; k++)
                {
                    Console.WriteLine(" ");
                }
                Console.WriteLine();
            }
        }
    }
}