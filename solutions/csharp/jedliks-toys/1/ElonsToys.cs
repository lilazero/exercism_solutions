using System;

class RemoteControlCar
{
    public static RemoteControlCar Buy() => new();

    private int distanceDriven = 0;

    public string DistanceDisplay() => $"Driven {distanceDriven} meters";

    private int battery = 100;

    public string BatteryDisplay()
    {
        if (battery >= 1)
            return $"Battery at {battery}%";
        else
            return "Battery empty";
    }

    public void Drive()
    {
        if (battery >= 1)
        {
            distanceDriven += 20;
            battery -= 1;
        }
        else
            BatteryDisplay();
    }
}
