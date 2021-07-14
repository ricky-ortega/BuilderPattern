using System;

namespace BuilderPattern
{
    class Program
    {

        static void Main(string[] args)
        {
            PizzaFactory pizzaFactory = new PizzaFactory();
            pizzaFactory.Run();
        }
    }
}
