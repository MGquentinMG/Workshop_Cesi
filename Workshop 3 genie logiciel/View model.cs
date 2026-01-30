namespace Workshop_3_genie_logiciel
{
    internal class View_model
    {
        private WordData NewChaine = new WordData();

        public string UpperWord(string input)
        {
            if (input.Length >= 1 && input.Length <= 8)
            {
                NewChaine.Word = input.ToUpper();
                return NewChaine.Word;
            }
            return null; 
        }
    }
}