using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminC
{
    internal class Inventory
    {
        List<Bus> buses;
        List<Trams> trams;
        List<Trolleybuses> trolleybuses;


        public Inventory( ) {
        Buses = new List<Bus>();
        Trams = new List<Trams>();
        Trolleybuses = new List<Trolleybuses>();
        }

        internal List<Bus> Buses { get => buses; set => buses = value; }
        internal List<Trams> Trams { get => trams; set => trams = value; }
        internal List<Trolleybuses> Trolleybuses { get => trolleybuses; set => trolleybuses = value; }
        public void AddBus(Bus bus)
        {
            Buses.Add(bus);
        }
        public void AddTram(Trams tram)
        {
            Trams.Add(tram);
        }
        public void AddTrolleybuses(Trolleybuses trolleybuse)
        {
            Trolleybuses.Add(trolleybuse);
        }

        public List<Bus> FindBusWithStatus(EnumTypStatus status)//pusta lista, dodaje busy z konkretnym statusem 
        {
            List<Bus> newBuses = new List<Bus>();
            foreach (Bus bus in Buses)
            {
                if ( bus.Status== status )
                {
                    newBuses.Add(bus);
                }
               
            }
            return newBuses;

      
        }
        public override string ToString()
        {
           StringBuilder sb = new StringBuilder();
            sb.AppendLine("All Busess");
            foreach (Bus bus in Buses)
            {
                sb.AppendLine(bus.ToString());
            }
            sb.AppendLine("All Trams");
            foreach (Trams tram in Trams)
            {
                sb.AppendLine(tram.ToString());
            }
            sb.AppendLine("All Trolleybuses");
            foreach (Trolleybuses t in Trolleybuses)
            {
                sb.AppendLine(t.ToString());
            }
            return sb.ToString();
        }
    }
}
