//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Workshop_3_genie_logiciel
//{
//    class Program
//    {
//        static void Main()
//        {
//            string word = "";
//            bool check_word = false;

//            while (check_word != true)
//            {
//                Console.WriteLine("Entrez votre chaîne (1 à 8 caractères) : ");
//                word = Console.ReadLine();
//                if (word.Length <= 8 && word.Length >= 1)
//                {
//                    check_word = true;
//                }
//                else
//                {
//                    Console.WriteLine("Votre chaine de caractere n'est pas good");
//                }
//            }

//            Console.WriteLine("Vous avez choisi le mot : " + word);
//            word = word.ToUpper();
//            Console.WriteLine();
//            Console.WriteLine("Voici votre mot en maj : " + word);
//            Console.ReadKey();
//        }
//    }
//}

using Workshop_3_genie_logiciel;

class Program
{
    static void Main()
    {
        View app = new View();
        app.Render();
    }
}
