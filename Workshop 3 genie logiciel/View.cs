using System;

namespace Workshop_3_genie_logiciel
{
    internal class View
    {
        // La View instancie son ViewModel pour communiquer avec lui
        private View_model _viewModel = new View_model();

        public void Render()
        {
            string result = null;

            // Boucle de saisie
            while (result == null)
            {
                Console.WriteLine("Entrez votre chaîne (1 à 8 caractères) : ");
                string input = Console.ReadLine();

                // On appelle la logique métier du ViewModel
                result = _viewModel.UpperWord(input);

                if (result == null)
                {
                    Console.WriteLine("Votre chaine de caractere n'est pas good (trop longue ou vide).");
                }
            }

            // Affichage du résultat final récupéré depuis le ViewModel
            Console.WriteLine("\nVous avez choisi le mot : " + result.ToLower());
            Console.WriteLine("Voici votre mot en maj : " + result);

            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey();
        }
    }
}