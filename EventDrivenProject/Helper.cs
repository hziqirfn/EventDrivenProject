using EventDrivenProject.models;

namespace EventDrivenProject
{
    public static class Helper
    {
        public static TicketcinemaContext db = new TicketcinemaContext(File.ReadAllText("Connection.txt"));
    }
}