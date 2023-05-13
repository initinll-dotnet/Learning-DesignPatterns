using _1_FactoryMethod.LogisticsApp.Factory;


namespace _1_FactoryMethod.LogisticsApp.Transport.ByAir;

internal class AirLogistics : Logistics
{
    public override ITransport CreateTransport()
    {
        return new Plane();
    }
}
