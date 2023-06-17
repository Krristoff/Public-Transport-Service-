using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminC
{
    internal class Trolleybuses : Vehicles
    {
        public Trolleybuses( string numPlate, int maxCapacity, FuelTypeEnum type, DateTime lastServiceDate) : base( numPlate, maxCapacity,  lastServiceDate)
        {

        }
    }
}
