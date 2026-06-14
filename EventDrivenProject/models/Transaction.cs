using System;
using System.Collections.Generic;

namespace EventDrivenProject.models;

public partial class Transaction
{
    public int TransactionId { get; set; }

    public int UserId { get; set; }

    public int ShowTimeId { get; set; }

    public DateTime BookingDate { get; set; }

    public int TotalAmount { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual ShowTime ShowTime { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
