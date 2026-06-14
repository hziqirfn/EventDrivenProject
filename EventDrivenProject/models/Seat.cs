using System;
using System.Collections.Generic;

namespace EventDrivenProject.models;

public partial class Seat
{
    public int SeatId { get; set; }

    public int HallId { get; set; }

    public string SeatNumber { get; set; } = null!;

    public string SeatType { get; set; } = null!;

    public decimal? Price { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual Hall Hall { get; set; } = null!;
}
