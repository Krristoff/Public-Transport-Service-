Public Transport Service
Our goal is to rebuild and digitize the public transportation management system in our city.

The first step is to create a registry of all vehicles located in the warehouse. All vehicles have an internal unique identifier, registration number, maximum passenger capacity, status (in need of repair / in operation / scrapped), fuel type (electric, gas, or hybrid), and the date of their last service. In general, the status is determined based on the date of the last service (0-6 months "in operation," 7-36 months "in need of repair," 37+ months "scrapped"). Each type of vehicle has several additional features:

All buses are gas-powered and have a pollution indicator. A bus is "in operation" if the last service date was within 0-6 months, and its pollution indicator is higher than 5; "in need of repair" if the service date was within 0-12 months and the pollution indicator is between 3 and 5, and "scrapped" otherwise.

Trolleybuses have both an electric and gas engine (hybrid).

All trams are electric and store the number of years in operation.

The first objective of the Public Transport Service is to determine how many vehicles of a specific type have a specific status.

The next step in the digitization process is tracking routes. A route is described by two or more stations and a list of vehicles that operate on it. Remember that only vehicles "in operation" can be assigned to a route. Each station has its name.
