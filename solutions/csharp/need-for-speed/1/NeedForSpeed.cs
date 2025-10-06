using System;

class RemoteControlCar
{
    public int Speed { get; }
    public int BatteryDrain { get; }
    private int battery;
    private int distanceDriven;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        battery = 100;
        distanceDriven = 0;
        Speed = speed;
        BatteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        if (battery - BatteryDrain < 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public int DistanceDriven()
    {
        return distanceDriven;
    }

    public void Drive()
    {
        if (BatteryDrained()==false){
            distanceDriven = distanceDriven + Speed;
            battery = battery - BatteryDrain;
        }
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private readonly int distance;
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }
    public bool TryFinishTrack(RemoteControlCar car)
    {
        int possibleDistance = (100/car.BatteryDrain) * car.Speed;
        return possibleDistance >= distance;
    }
}
