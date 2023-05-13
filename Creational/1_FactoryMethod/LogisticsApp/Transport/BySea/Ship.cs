using _1_FactoryMethod.LogisticsApp.Factory;

namespace _1_FactoryMethod.LogisticsApp.Transport.BySea;

public class Ship : ITransport
{
    public string Deliver()
    {
        return "Deliver by sea in a container";
    }
}
