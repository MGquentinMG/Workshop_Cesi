using System;

namespace EasySave
{
    class Program
    {
        static void Main()
        {
            string word;
            Console.WriteLine("Entrez votre chaîne (1 à 8 caractères) : ");
            word = Console.ReadLine();
            Console.WriteLine("Vous avez choisi le mot : " + word); 
            word = word.ToUpper();
            Console.WriteLine();
            Console.WriteLine("Voici votre mot en maj : "+ word);
            Console.ReadKey();
        }
    }
}