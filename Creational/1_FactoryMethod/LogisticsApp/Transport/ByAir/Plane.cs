using _1_FactoryMethod.LogisticsApp.Factory;

namespace _1_FactoryMethod.LogisticsApp.Transport.ByAir;

public class Plane : ITransport
{
    public string Deliver()
    {
        return "Deliver by air in a cargo";
    }
}
