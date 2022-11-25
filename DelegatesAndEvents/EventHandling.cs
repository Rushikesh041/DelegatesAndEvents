using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void EventHandler(string name);
    public class EventHandling
    {
        public class operation
        {
            public event EventHandler events;

            public void Action(string name)
            {
                if (events != null)
                {
                    events(name);
                    Console.WriteLine(name);
                }
                else
                {
                    Console.WriteLine("Not Registered");
                }
            }
        }
        private static void CatchEvent(string name)
        {
            Console.WriteLine("Method Calling");
        }
        public static void ImplementEvent()
        {
            operation op = new operation();
            op.Action("Event Calling");

            Console.WriteLine();
            op.events += new EventHandler(CatchEvent);
            op.Action("Event Called");
        }
    }
}
