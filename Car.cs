public class Car
{
    private Engine _engine;

    public Car()
    {
        _engine = new Engine();
    }

    public void Start()
    {
        _engine.GetFuelSystem().GetFuelPump().Start();
    }
}

public class Engine
{
    private FuelSystem _fuelSystem;

    public Engine()
    {
        _fuelSystem = new FuelSystem();
    }

    public FuelSystem GetFuelSystem()
    {
        return _fuelSystem;
    }
}

public class FuelSystem
{
    private FuelPump _fuelPump;

    public FuelSystem()
    {
        _fuelPump = new FuelPump();
    }

    public FuelPump GetFuelPump()
    {
        return _fuelPump;
    }
}

public class FuelPump
{
    public void Start()
    {
        // start the fuel pump
    }
}