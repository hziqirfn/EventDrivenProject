using EventDrivenProject.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenProject
{
    public class Helper
    {
        public static TicketcinemaContext db = new TicketcinemaContext(File.ReadAllText("Connection.txt"));
    }
}
