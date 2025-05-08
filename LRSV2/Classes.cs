using System.Text.Json;

namespace LRSV2;

public class Classes
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int IsAdmin { get; set; }
        public string Seat { get; set; }
    }
    public class Reservation
    {
        public int Room { get; set; }
        public int Seat { get; set; }
    }

    public class Seats
    {
        public int Room { get; set; }
        public int Seat { get; set; }
        public int IsOccupied { get; set; }
    }
    public class UserInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int IsAdmin { get; set; }
        public string Seat { get; set; }
    }

    public class Statistics
    {
        public int Room { get; set; }
        public int Seat { get; set; }
        public string Time { get; set; }
        public string User { get; set; }
    }
    public static readonly JsonSerializerOptions options = new()
    {
        PropertyNameCaseInsensitive = true
    };
}