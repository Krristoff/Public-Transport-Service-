namespace EgzaminC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bus bus1 = new Bus( "123", 1234, new DateTime(2023, 05, 17), 3);
            Bus bus2 = new Bus( "12", 1234, new DateTime(2023, 06, 16), 3);
            Bus bus3 = new Bus( "1233", 12324, new DateTime(2023, 06, 16), 7);
            Bus bus4 = new Bus( "1233", 12324, new DateTime(2023, 06, 07), 4);


            Trams tram1 = new Trams( "1", 123, new DateTime(2023, 06, 07), 4);
            Trams tram2 = new Trams( "12", 12324, new DateTime(2023, 06, 07), 4);

            Trolleybuses trolleybuse1 = new Trolleybuses( "1", 123, FuelTypeEnum.electric ,new DateTime(2023, 06, 07));
            Trolleybuses trolleybuse2 = new Trolleybuses( "3", 123, FuelTypeEnum.hybrid, new DateTime(2023, 06, 07));

            Inventory i=new Inventory();

            i.AddBus(bus1);
            i.AddBus(bus2);
            i.AddBus(bus3);
            i.AddBus(bus4);

            i.AddTram(tram1);
            i.AddTram(tram2);

            i.AddTrolleybuses(trolleybuse1);
            i.AddTrolleybuses(trolleybuse2 );

            Console.WriteLine(i);

            Station station1 = new Station("Azory");
            Station station2 = new Station("Lesiosko");
            Station station3 = new Station("Śliczna");

            Console.WriteLine(station1);

            Route route1 = new Route(new List<Station>() { station1, station2 });
            Route route2 = new Route(new List<Station>() { station1});

            route1.AddVechical(tram2 );
            route1.AddVechical(bus2);
            route1.AddVechical(trolleybuse2);


            Console.WriteLine(route1);

        }
    }
}