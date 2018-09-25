using System;
using ConsoleTheater.Models;

namespace ConsoleTheater
{
  class Program
  {
    static void Main(string[] args)
    {
      Theater myTheater = new Theater("Mark's Megaplex");
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

      myTheater.AddShowtime();

      myTheater.PrintMovies();

    }
  }
}
