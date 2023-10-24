// See https://aka.ms/new-console-template for more information

Console.WriteLine("INICIO");
Console.WriteLine("Ejemplo ABSTRACT FACTORY Libro 23 patrones Java");
IFabricaVehiculo fabrica;
IAutomovil automovil;
IScooter scooter;

// * para vehiculos electricos...
Console.WriteLine("\nPara vehiculos electricos");
fabrica = new FabricaVehiculoElectricidad();
automovil = fabrica.CreaAutomovil();
scooter = fabrica.CreaScooter();
automovil.modelo();
scooter.modelo();

// * para vehiculos de gasolina
Console.WriteLine("\nPara vehiculos de gasolina");
fabrica = new FabricaVehiculoGasolina();
automovil = fabrica.CreaAutomovil();
scooter = fabrica.CreaScooter();
automovil.modelo();
scooter.modelo();

// TODO write it down!!!

Console.WriteLine("FIN");