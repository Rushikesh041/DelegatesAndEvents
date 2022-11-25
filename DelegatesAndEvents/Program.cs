namespace DelegatesAndEvents
{
    public class Program
    {
        public static event DelEventHandler Del;
        static void Main(string[] args)
        {
<<<<<<< HEAD
=======
            Console.WriteLine("******************** Event Handling *****************************");
            EventHandling.ImplementEvent();

>>>>>>> EventHandling
            Del += new DelEventHandler(EventProblem.India);
            Del += new DelEventHandler(EventProblem.USA);
            Del += new DelEventHandler(EventProblem.England);
            Del.Invoke();

            ArrayDelegates.ImplementDelegates();
        }
    }
}