using System;
using ConsoleTheater.Models;


namespace ConsoleTheater
{
  class Program
  {
    static void Main(string[] args)
    {
      Theater myTheater = new Theater("Jackson's Jmovie theater");
      myTheater.Initialize();
      Movie titanic = new Movie("Titanic");
      Movie gladiator = new Movie("Gladiator");
      Movie forestGump = new Movie("ForestGump");
      Movie breakfastClub = new Movie("BreakfastClub");
      myTheater.Movies.Add(titanic);
      myTheater.Movies.Add(gladiator);
      myTheater.Movies.Add(forestGump);
      myTheater.Movies.Add(breakfastClub);

      myTheater.AddRoom(titanic, 100);

      myTheater.AddRoom(gladiator, 101);
      myTheater.AddRoom(forestGump, 102);
      myTheater.AddRoom(breakfastClub, 103);

      //int corresponds to room number
      myTheater.AddShowtime("2:00", 0);
      myTheater.AddShowtime("4:00", 0);
      myTheater.AddShowtime("5:00", 0);
      myTheater.AddShowtime("3:00", 1);
      myTheater.AddShowtime("4:00", 1);
      myTheater.AddShowtime("5:00", 2);
      myTheater.AddShowtime("6:00", 2);
      myTheater.AddShowtime("2:00", 3);
      myTheater.AddShowtime("3:00", 3);

      myTheater.PrintMovies();

      string userChoice = Console.ReadLine();
      if (userChoice == "1")
      {
        Console.WriteLine($"{titanic.Title}");
      }
      if (userChoice == "2")
      {
        Console.WriteLine($"{gladiator.Title}");
      }
      if (userChoice == "3")
      {
        Console.WriteLine($"{forestGump.Title}");
      }
      if (userChoice == "4")
      {
        Console.WriteLine($"{breakfastClub.Title}");
      }


    }
  }
}
