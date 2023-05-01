using System;
using Riddles.Models;
using System.Collections.Generic;

namespace Riddles
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("The Great Sphinx approaches...");
      Console.WriteLine("In order to reach the tombs, you must pass a series of 3 riddles. Think carefully before you respond.");
      for (int index = 1; index <= 3; index ++)
      {
        Random rnd = new Random();
        int randomNumber = rnd.Next(12);
        Console.WriteLine(randomNumber);
        Console.WriteLine($"Riddle #{index}: {Sphinx.GetRiddle(randomNumber)} (enter a single word response)");
        string userResponse = Console.ReadLine();
        if (userResponse.ToLower() == Sphinx.GetAnswer(randomNumber))
        {
          Console.WriteLine("Congratulations, the Sphinx is pleased with your response.");
          if (index == 3)
          {
            Console.WriteLine("The Sphinx has enjoyed the game... and allows you to pass.");
          }
        }
        else
        {
          Console.WriteLine("The Sphinx is unimpressed with your response... Another skeleton gets added to the tomb.");
          break;
        }
      }
      
    }
  }
}

