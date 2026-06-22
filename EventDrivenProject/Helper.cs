using EventDrivenProject.models;

namespace EventDrivenProject
{
    public static class Helper
    {
        public static TicketcinemaContext db =
            new TicketcinemaContext(
                File.ReadAllText(
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Connection.txt")
                )
            );
    }
}