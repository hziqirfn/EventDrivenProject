using System;
using System.Collections.Generic;

namespace EventDrivenProject.models;

public partial class Movie
{
    public int MovieId { get; set; }

    public string Title { get; set; } = null!;

    public string Image { get; set; } = null!;

    public string Genre { get; set; } = null!;

    public string Duration { get; set; }

    public string? Description { get; set; }

    public DateOnly? ReleaseDate { get; set; }

    public virtual ICollection<ShowTime> ShowTimes { get; set; } = new List<ShowTime>();
}
