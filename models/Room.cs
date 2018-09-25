using System.Collections.Generic;

namespace ConsoleTheater.Models
{

  public class Room
  {
    public Movie Movie { get; set; }
    private Dictionary<string, int> Showtimes { get; set; }

    public int MaxSeats { get; set; }

    public void AddShowtime(string time)
    {
      Showtimes.Add(time, MaxSeats);
    }


    //example of printing dictionaries
    public void PrintShowtimes()
    {
      foreach (KeyValuePair<string, int> showtime in Showtimes)
      {
        System.Console.WriteLine($"{showtime.Key} - Available Seats {showtime.Value}");
      }
    }


    public Room(Movie movie, int maxSeats)
    {
      Movie = movie;
      MaxSeats = maxSeats;
      Showtimes = new Dictionary<string, int>();

    }
  }
}