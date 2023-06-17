using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminC
{
    internal class Station
    {
        string name;

        public Station(string name)
        {
            Name = name;
        }

        public string Name { get => name; set => name = value; }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
