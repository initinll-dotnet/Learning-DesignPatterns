using _1_FactoryMethod.LogisticsApp.Factory;

namespace _1_FactoryMethod.LogisticsApp.Transport.ByRoad;

public class RoadLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Truck();
    }
}
