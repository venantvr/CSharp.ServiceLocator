using Business;

namespace Sample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var mgr = new Manager();
            var order = new Order();

            mgr.Process(order);
        }
    }
}