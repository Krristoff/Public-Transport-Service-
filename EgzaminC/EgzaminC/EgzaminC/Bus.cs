using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminC
{
    internal class Bus : Vehicles
    {
        int pollutionIndicator;


        public Bus( string numPlate, int maxCapacity, DateTime lastServiceDate, int pollutionIndicator) : base( numPlate, maxCapacity,  lastServiceDate)
        {
             PollutionIndicator=pollutionIndicator;
            Type = FuelTypeEnum.gas;
        }

        public int PollutionIndicator { get => pollutionIndicator; set => pollutionIndicator = value; }

        public override void SpecifyState()
        {
            DateTime today = DateTime.Now;
            TimeSpan difference = today - LastServiceDate;
            int daysSinceService = difference.Days;
            if(difference.Days > 0 && difference.Days<6 && PollutionIndicator>5 )
            {
                Status = EnumTypStatus.inOperation;
            }
            else if( difference.Days<12 && pollutionIndicator<=5 && pollutionIndicator>=3)
            { Status = EnumTypStatus.needRepair; }
            else
            {
                Status = EnumTypStatus.forScrap;
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()}, {pollutionIndicator}";
        }
    }
}
