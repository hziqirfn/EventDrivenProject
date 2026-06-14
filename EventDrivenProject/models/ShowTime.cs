using System;
using System.Collections.Generic;

namespace EventDrivenProject.models;

public partial class ShowTime
{
    public int ShowTimeId { get; set; }

    public int MovieId { get; set; }

    public int HallId { get; set; }

    public DateOnly? ShowDate { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public virtual Hall Hall { get; set; } = null!;

    public virtual Movie Movie { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
