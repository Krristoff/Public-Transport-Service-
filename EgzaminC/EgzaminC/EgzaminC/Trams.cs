using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminC
{
    internal class Trams : Vehicles
    {
        int yearsinService;
        public Trams( string numPlate, int maxCapacity,  DateTime lastServiceDate ,int yearsinService) : base( numPlate, maxCapacity, lastServiceDate)
        {
            Type = FuelTypeEnum.electric;
            YearsinService= yearsinService;
        }

        public int YearsinService { get => yearsinService; set => yearsinService = value; }
        public override string ToString()
        {
            return $"{base.ToString()}, {YearsinService}";
        }
    }
  
}
