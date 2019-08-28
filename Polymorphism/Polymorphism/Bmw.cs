using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    
    class Bmw:Car
    {
        private string brand = "Bmw";
        public string Model { get; set; }

        public Bmw() { }

        public Bmw(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("Brand: {0},HorsePower: {1}, Color: {2}", brand, HP, Color);
        }

        public override void Repair()
        {
            Console.WriteLine("The Bmw {0} was repaired", Model);
        }
    }
}
