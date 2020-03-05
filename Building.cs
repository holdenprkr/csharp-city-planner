using System;
using System.Collections.Generic;

namespace Planner
{
    public class Building
    {
        public Building(string address)
        {
            _address = address;
        }

        public void Design(string name)
        {
            _designer = name;
        }
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string name)
        {
            _owner = name;
        }

        public void Print()
        {
            Console.WriteLine(this._address);
            Console.WriteLine($"-----------------------");
            Console.WriteLine($"Designed by {this._designer}");
            Console.WriteLine($"Constructed on {this._dateConstructed}");
            Console.WriteLine($"Owned by {this._owner}");
            Console.WriteLine($"{this.Volume} cubic meters of space");
            Console.WriteLine("");
        }

        private string _designer { get; set; }

        private DateTime _dateConstructed { get; set; }

        private string _address { get; set; }

        private string _owner { get; set; }

        public int Stories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }
    }
}