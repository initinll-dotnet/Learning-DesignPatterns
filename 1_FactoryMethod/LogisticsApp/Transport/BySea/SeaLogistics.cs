using _1_FactoryMethod.LogisticsApp.Factory;

namespace _1_FactoryMethod.LogisticsApp.Transport.BySea;

public class SeaLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}
