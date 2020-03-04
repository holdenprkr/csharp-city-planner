using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public City (string name)
        {
            _name = name;
        }

        public void SetMayor (string mayor)
        {
            _mayor = mayor;
        }

        public void SetYearEstablished (int year)
        {
            _yearEstablished = year;
        }

        private string _name { get; set; }

        private string _mayor { get; set; }

        private int _yearEstablished { get; set; }

        // private List<List<string>> buildings;

        // public List<List<string>> GetBuildings ()
        // {
        //     return buildings;
        // }

        // public void SetBuildings (List<List<string>> value)
        // {
        //     buildings = value;
        // }
    }
}