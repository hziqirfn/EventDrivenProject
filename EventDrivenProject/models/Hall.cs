using System;
using System.Collections.Generic;

namespace EventDrivenProject.models;

public partial class Hall
{
    public int HallId { get; set; }
    public int RoomNumber { get; set; }

    public int CinemaId { get; set; }

    public string HallName { get; set; } = null!;

    public string HallType { get; set; }

    public int TotalSeats { get; set; }

    public virtual Cinema Cinema { get; set; } = null!;

    public virtual ICollection<Seat> Seats { get; set; } = new List<Seat>();

    public virtual ICollection<ShowTime> ShowTimes { get; set; } = new List<ShowTime>();
}
