using System;
namespace Uppgift_2._13
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lön för Hashim?");
            int Hashim = int.Parse(Console.ReadLine());
            Console.WriteLine("lön för Mire?");
            int Mire = int.Parse(Console.ReadLine());
            Console.WriteLine("lön för Mustafa?");
            int Mustafa = int.Parse(Console.ReadLine());

            Console.WriteLine("Hashim " + Hashim + "kr" + " Mire " + Mire + "kr " + " Mustafa " + Mustafa + "kr ");

            Console.WriteLine("Medellönen för personalen är " + (Hashim + Mire + Mustafa) / 3);
        }
    }
}

