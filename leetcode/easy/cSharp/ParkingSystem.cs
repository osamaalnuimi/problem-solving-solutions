public class ParkingSystem
{
    private Dictionary<int, int> dic;
    public ParkingSystem(int big, int medium, int small)
    {
        dic = new Dictionary<int, int>()
        {
            {1, big },
            {2, medium },
            {3, small},
        };
          
    }

    public bool AddCar(int carType)
    {
        if (dic[carType] == 0)
        {
            return false;
        }

        dic[carType]--;
        return true;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */
