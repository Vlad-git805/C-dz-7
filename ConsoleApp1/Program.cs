using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ConsoleApp1
{

    abstract class Being
    {
        protected string kind { get; set; }
        protected string name { get; set; }

        public abstract void Show_info();
        public abstract void Say();
    }

    class Animal : Being
    {
        public Animal()
        {
            kind = "no kind";
            name = "no name";

        }

        public Animal(string name, string kind)
        {
            this.name = name;
            this.kind = kind;
        }

        public override void Show_info()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Kind: " + kind);
        }

        public override void Say()
        {
            Console.WriteLine("I say");
        }
    }

    class Reptile : Animal
    {
        public float temperature { get; set; }

        public Reptile() : base()
        {
            temperature = 0;
        }

        public Reptile(string name, string kind, float temperature) : base(name, kind)
        {
            this.temperature = temperature;
        }

        public override void Show_info()
        {
            base.Show_info();
            Console.WriteLine("Temperature: " + temperature);
        }

        public override void Say()
        {
            base.Say();
            Console.Write(" im a reptile LOL! ");
        }
    }

    class Birdie : Animal
    {
        public float flight_speed { get; set; }

        public Birdie() : base()
        {
            flight_speed = 0;
        }

        public Birdie(string name, string kind, float flight_speed) : base(name, kind)
        {
            this.flight_speed = flight_speed;
        }

        public override void Show_info()
        {
            base.Show_info();
            Console.WriteLine("Flight speed: " + flight_speed);
        }

        public override void Say()
        {
            base.Say();
            Console.Write(" im a birde LOL! ");
        }

    }

    class Fish : Animal
    {
        public float immersion_depth { get; set; }

        public Fish() : base()
        {
            immersion_depth = 0;
        }

        public Fish(string name, string kind, float immersion_depth) : base(name, kind)
        {
            this.immersion_depth = immersion_depth;
        }

        public override void Show_info()
        {
            base.Show_info();
            Console.WriteLine("Immersion depth: " + immersion_depth);
        }

        public override void Say()
        {
            base.Say();
            Console.Write(" im a fish LOL! ");
        }
    }

    class Turtle : Reptile
    {
        public string color { get; set; }

        public Turtle() : base()
        {
            color = "no color";
        }

        public Turtle(string name, string kind, float temperature, string color) : base(name, kind, temperature)
        {
            this.color = color;
        }

        public override void Show_info()
        {
            base.Show_info();
            Console.WriteLine("Color: " + color);
        }

        public override void Say()
        {
            base.Say();
            Console.WriteLine("I'm a Turtle, the fastest creature in the world");
        }

        public void Crow()
        {
            Console.WriteLine("I crow!!!");
        }

        public void Swim()
        {
            Console.WriteLine("I swim!!!");
        }
    }

    class Sparrow : Birdie
    {
        public string color { get; set; }

        public Sparrow() : base()
        {
            color = "no color";
        }

        public Sparrow(string name, string kind, float flight_speed, string color) : base(name, kind, flight_speed)
        {
            this.color = color;
        }

        public override void Show_info()
        {
            base.Show_info();
            Console.WriteLine("Color: " + color);
        }

        public override void Say()
        {
            base.Say();
            Console.WriteLine("I'm a sparrow, Jack Іparrow");
        }

        public void Fly()
        {
            Console.WriteLine("I fly!!!");
        }
    }

    class Crow : Birdie
    {
        public string color { get; set; }

        public Crow() : base()
        {
            color = "no color";
        }

        public Crow(string name, string kind, float flight_speed, string color) : base(name, kind, flight_speed)
        {
            this.color = color;
        }

        public override void Show_info()
        {
            base.Show_info();
            Console.WriteLine("Color: " + color);
        }

        public override void Say()
        {
            base.Say();
            Console.WriteLine("Сar Сar bitch");
        }

        public void Fly()
        {
            Console.WriteLine("I fly!!!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Being> zoo = new List<Being>(4);
            zoo.Add(new Turtle() { color = "green", temperature = 10 });
            zoo.Add(new Sparrow() { color = "brown" });
            zoo.Add(new Crow() { color = "red" });

            foreach (Being being in zoo)
            {
                being.Say();
                Console.WriteLine();
            }
        }
    }
}
