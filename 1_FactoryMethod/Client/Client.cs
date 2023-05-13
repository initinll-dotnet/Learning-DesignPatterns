using _1_FactoryMethod.LogisticsApp.Factory;
using _1_FactoryMethod.LogisticsApp.Transport.ByAir;
using _1_FactoryMethod.LogisticsApp.Transport.ByRoad;
using _1_FactoryMethod.LogisticsApp.Transport.BySea;

namespace _1_FactoryMethod.Client;

public class Client
{
    public void Main()
    {
        ClientCode(new RoadLogistics());
        ClientCode(new SeaLogistics());
        ClientCode(new AirLogistics());
    }

    public void ClientCode(Logistics logistics)
    {
        Console.WriteLine($"Client: I am not aware of creator's class but it still works \n {logistics.PlanDelivery()}");
    }
}
