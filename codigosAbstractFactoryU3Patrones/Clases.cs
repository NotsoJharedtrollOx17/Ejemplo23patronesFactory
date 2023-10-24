// * Nombre: Abraham Jhared Flores Azcona
// * #: 19211640


public interface IAutomovil {
    public void modelo() {}
}

public class AutomovilElectricidad : IAutomovil {
    public void modelo() {
        Console.WriteLine("Automovil Eléctrico");
    }
}

public class AutomovilGasolina : IAutomovil {
    public void modelo() {
        Console.WriteLine("Automovil Gasolina");
    }
}

public interface IScooter {
    public void modelo() {}
}

public class ScooterElectricidad : IScooter {
    public void modelo() {
        Console.WriteLine("Scooter Eléctrico");
    }
}

public class ScooterGasolina : IScooter {
    public void modelo() {
        Console.WriteLine("Scooter Gasolina");
    }
}

public interface IFabricaVehiculo {
    public IAutomovil CreaAutomovil();

    public IScooter CreaScooter();
}

public class FabricaVehiculoElectricidad : IFabricaVehiculo {
    public IAutomovil CreaAutomovil() {
        return new AutomovilElectricidad();
    }

    public IScooter CreaScooter() {
        return new ScooterElectricidad();
    }
}

public class FabricaVehiculoGasolina : IFabricaVehiculo {
    public IAutomovil CreaAutomovil() {
        return new AutomovilGasolina();
    }

    public IScooter CreaScooter() {
        return new ScooterGasolina();
    }
}