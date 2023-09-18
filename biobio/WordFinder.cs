namespace biobio
{
    public class WordFinder

    {
        public void FindThirdWord(string sentence)
        {
            string[] words = sentence.Split(' ');
            if (words.Length >= 3)
            {
                Console.WriteLine($"Det tredje ordet är: {words[2]}");
            }
            else
            {
                Console.WriteLine("Meningen innehåller inte minst 3 ord.");
            }
        }
    }
    
    }
