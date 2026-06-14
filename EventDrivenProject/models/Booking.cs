using System;
using System.Collections.Generic;

namespace EventDrivenProject.models;

public partial class Booking
{
    public int BookDetailId { get; set; }

    public int TransactionId { get; set; }

    public int SeatId { get; set; }

    public decimal TicketPrice { get; set; }

    public virtual Seat Seat { get; set; } = null!;

    public virtual Transaction Transaction { get; set; } = null!;
}
