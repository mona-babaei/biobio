namespace biobio
{
   public class GroupManager
   {
     public void CheckGroupPrice(int[] ages)
      {
         int totalCost = 0;
            for (int i = 0; i < ages.Length; i++)
             {
             if (ages[i] < 20)
                {
                    totalCost += 80;
                 }
             else if (ages[i] > 64)
             {
                    totalCost += 90;
               }
             else
             {
                     totalCost += 120;
                }
            }
            Console.WriteLine($"Antal personer: {ages.Length}");
            Console.WriteLine($"Totalkostnad: {totalCost}kr");
        }
    }

}