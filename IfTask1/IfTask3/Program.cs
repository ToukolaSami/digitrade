using System;

namespace IfTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää käyttäjän syöttämästä luvusta," +
                   " onko se positiivinen vai negatiivinen, sekä onko se parillinen vai pariton!");
            Console.Write("Syötä kokonaisluku: ");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 0)
            {
                Console.WriteLine($"Luku {userNumber} on nolla");

            }

            else if (userNumber > 0 && userNumber % 2 == 0)
            {
                Console.WriteLine($"Luku {userNumber} on positiivinen ");
            }

            else
            {
                Console.WriteLine($"Luku {userNumber} on negatiivinen");
            }
        }
    }
}
