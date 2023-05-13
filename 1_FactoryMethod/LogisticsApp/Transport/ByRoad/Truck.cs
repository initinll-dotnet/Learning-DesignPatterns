using _1_FactoryMethod.LogisticsApp.Factory;

namespace _1_FactoryMethod.LogisticsApp.Transport.ByRoad;

public class Truck : ITransport
{
    public string Deliver()
    {
        return "Deliver by land in a box";
    }
}
