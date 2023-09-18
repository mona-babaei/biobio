namespace biobio
{
    public class TextRepeater
    {
        public void RepeatText(string text)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}.{text} ");
            }
            Console.WriteLine();
        }
    }
  
}