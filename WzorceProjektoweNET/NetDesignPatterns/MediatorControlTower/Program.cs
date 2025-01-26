using MediatorControlTower;

IControlTower controlTower = new ControlTower();

Airplane airplane1 = new PassengerAirplane(controlTower, "Flight A1");
Airplane airplane2 = new PassengerAirplane(controlTower, "Flight B2");
Airplane airplane3 = new PassengerAirplane(controlTower, "Flight C3");

controlTower.AddAirplane(airplane1);
controlTower.AddAirplane(airplane2);
controlTower.AddAirplane(airplane3);

airplane1.SendRequest("Prośba o lądowanie");
airplane2.SendRequest("Prośba o start");