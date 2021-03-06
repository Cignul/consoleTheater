using System.Collections.Generic;

namespace ConsoleTheater.Models
{
  public class Theater
  {
    public string Name { get; private set; }
    public List<Movie> Movies { get; set; }

    public List<Concession> Concessions { get; set; }

    private List<Room> Rooms { get; set; }

    public List<Ticket> Tickets { get; set; }

    public void Initialize()

    {
      Concessions.Add(new Concession("popcorn", 12.54m));
      Concessions.Add(new Concession("snacks", 5.00m));
      Concessions.Add(new Concession("drink", 8.00m));

    }

    public void AddRoom(Movie movie, int seats)
    {
      Rooms.Add(new Room(movie, seats));
    }
    //I GAVE UP HERE - UNCOMMENT AND CONTINUE
    // public void AddTicket(Ticket ticket, int seats)
    // {
    //   Tickets.Add(new Ticket(ticket, ConsoleTheater.Models.Movie, 5.00m));
    // }
    public void AddShowtime(string showtime, int roomIndex)
    {
      Rooms[roomIndex].AddShowtime(showtime);
    }

    public void PrintMovies()
    {
      for (int i = 0; i < Rooms.Count; i++)
      {
        System.Console.WriteLine($@"
       {i + 1}. {Rooms[i].Movie.Title} 
       Showtimes:");
        Rooms[i].PrintShowtimes();
      }
      {
        System.Console.WriteLine();
      }

    }
    public void PrintTickets()
    {
      for (int i = 0; i < Tickets.Count; i++)
      {
        System.Console.WriteLine($@"
       {i + 1}.Price: {Tickets[i].Price} 
       ");

        {
          System.Console.WriteLine("WOULD YOU like to buy a ticket (testing)??");
        }
      }
    }

    public Theater(string name)
    {
      Name = name;
      Rooms = new List<Room>();
      Movies = new List<Movie>();
      Concessions = new List<Concession>();
    }
  }
}
