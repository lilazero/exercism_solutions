class RemoteControlCar
{
    public int Speed { get; }
    public int BatteryDrain { get; }
    private int battery;
    private int distanceDriven;
    public RemoteControlCar(int speed, int batteryDrain) =>
        (battery, distanceDriven, Speed, BatteryDrain) = (100, 0, speed, batteryDrain);

    /* {
        battery = 100;
        distanceDriven = 0;
        Speed = speed;
        BatteryDrain = batteryDrain;
    } */
    
    public bool BatteryDrained() => battery - BatteryDrain < 0;
/*      {
        if (battery - BatteryDrain < 0)
        {
            return true;
        }
        else
        {
            return false;
        }
        } 
*/

    public int DistanceDriven() => distanceDriven;
    /* {
        return distanceDriven;
    } */
    public void Drive()
    {
        if (!BatteryDrained())
        {
            distanceDriven += Speed;
            battery -= BatteryDrain;
        }
    }
    public static RemoteControlCar Nitro() => new(50, 4);
    /* {
        return new RemoteControlCar(50, 4);
    } */
}

class RaceTrack
{
    private readonly int distance;
    public RaceTrack(int distance) => this.distance = distance;
    /*  {
         this.distance = distance;
     } */
    public bool TryFinishTrack(RemoteControlCar car) => 100 / car.BatteryDrain * car.Speed >= distance;
    /*  {
        int possibleDistance = 100 / car.BatteryDrain * car.Speed;
        return possibleDistance >= distance; 
        }
    */
}
