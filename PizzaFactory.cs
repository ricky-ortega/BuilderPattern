using System;
using System.Collections.Generic;

namespace BuilderPattern
{

    /// <summary>
    /// Pizza Da Hut
    /// 
    /// Handling Orders:
    /// 
    /// Create different pizza types 
    /// -Classic 
    /// --- Pepproni, Cheese, Marinara
    /// 
    /// Output / print with the Run method 
    /// </summary>
    internal class PizzaFactory
    {

        //public ClassicPizza ClassicPizza { get; set; }
        //public HawaiianPizza HawaiianPizza { get; set; }

        public PizzaFactory()
        {

        }

        internal void Run()
        {
            Pizza pizza = Pizza.BuildClassicPizza();

            pizza.Display();

            Pizza custom = Pizza.GetEmptyPizza("hawaiian")
            .WithToppings(new List<Topping>
            {
                new Topping{Name = "Pineapple"},
                new Topping{Name = "Cheese"},
                new Topping{Name = "Ham"},
            });

            custom.Display();
            pizza.Display();

            //ClassicPizza.Display();
            //HawaiianPizza.Display();
        }
    }


    internal sealed class Pizza
    {
        private string name;
        private List<Topping> _toppings = new List<Topping>();
        private List<Sauce> _sauces = new List<Sauce>();

        private Pizza()
        {

        }



        internal static Pizza BuildClassicPizza()
        {

            return new Pizza
            {
                name = "Classic",
                _toppings = new List<Topping>
                {
                    new Topping { Name = "Pepperoni" },
                    new Topping { Name = "Cheese" }
                },

                _sauces = new List<Sauce>
                {
                    new Sauce {Name = "Marinara"}
                }
            };
        }

        internal static Pizza GetEmptyPizza(string name)
        {

            return new Pizza
            {
                name = name
            };
        }

        internal void Display()
        {
            Console.WriteLine($"You ordered a {name}:");
            foreach (var item in _toppings)
            {
                Console.WriteLine(item.Name);
            }
            foreach (var item in _sauces)
            {
                Console.WriteLine(item.Name);
            }

        }

        internal Pizza WithToppings(List<Topping> toppings)
        {
            _toppings = toppings;
            return this;
        }
    }

    internal class Sauce
    {
        public string Name { get; set; }
    }

    internal class Topping
    {
        public string Name { get; set; }
    }

}