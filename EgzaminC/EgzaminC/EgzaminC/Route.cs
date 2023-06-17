using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminC
{
    internal class Route
    {
        List<Station> stations;
        List<Vehicles> vehicles;

        public Route(List<Station> stations)
        {
            if (stations.Count >= 2)
            {

                Stations = stations;
                Vehicles = new List<Vehicles>();
            }
            else
            {
              
                Console.WriteLine("Za mało stacji");
               
            }


        }

        internal List<Station> Stations { get => stations; set => stations = value; }
        internal List<Vehicles> Vehicles { get => vehicles; set => vehicles = value; }

        public void AddStation(Station station)
        {
            stations.Add(station);
        }
        public void AddVechical(Vehicles vehicle)
        {
            if(vehicle.Status==EnumTypStatus.inOperation)
            {
                Vehicles.Add(vehicle);
            }
            else 
            {
                Console.WriteLine("Pojazd nie jest w użytku");
             }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Wszystkie stacje na trasie");
            foreach(Station station in Stations) { 
             sb.AppendLine(station.ToString());
            }
            sb.AppendLine("Wszystkie pojazdy na trasie");
            foreach (Vehicles vehicle in Vehicles)
            {
                sb.AppendLine(vehicle.ToString());
            }
            return sb.ToString();
        }


    }
}
