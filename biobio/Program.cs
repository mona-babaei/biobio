using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace biobio;

class Program
{
  static void Main(string[] args)
   {
       
  TicketManager ticketManager = new TicketManager();
  GroupManager groupManager = new GroupManager();
  TextRepeater textRepeater = new TextRepeater();
   WordFinder wordFinder = new WordFinder();

    bool keepRunning = true;

    while (keepRunning)
     {
    Console.WriteLine("Välkommen till huvudmenyn!");
    Console.WriteLine("1. Biobiljettpris");
    Console.WriteLine("2. Pris för sällskap");
    Console.WriteLine("3. Upprepa text 10 gånger");
    Console.WriteLine("4. Hitta tredje ordet");
    Console.WriteLine("0. Avsluta");

     string choice = Console.ReadLine();

     switch (choice)
            {
     case "1":
     Console.WriteLine("Ange din ålder:");          //agegroup
     int age = int.Parse(Console.ReadLine());
     ticketManager.CheckTicketPrice(age);
     break;

     case "2":
        Console.WriteLine("Hur många personer är ni?");     //gest
        int count = int.Parse(Console.ReadLine());
         int[] ages = new int[count];
          for (int i = 0; i < count; i++)
            {
         Console.WriteLine($"Ange ålder för person {i + 1}:");
         ages[i] = int.Parse(Console.ReadLine());
            }
       groupManager.CheckGroupPrice(ages);
      break;

      case "3":
           Console.WriteLine("Ange en text att upprepa:");
           string text = Console.ReadLine();
           textRepeater.RepeatText(text);
      break;

      case "4":
           Console.WriteLine("Ange en mening med minst 3 ord:");
                string sentence = Console.ReadLine();
                wordFinder.FindThirdWord(sentence);
                     break;

      case "0":
            keepRunning = false;
                     break;

                    default:
                    Console.WriteLine("Felaktig input, försök igen.");
                    break;
                }
            }
        }
    }
