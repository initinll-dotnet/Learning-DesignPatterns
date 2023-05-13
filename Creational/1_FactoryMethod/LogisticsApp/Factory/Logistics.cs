namespace _1_FactoryMethod.LogisticsApp.Factory;

public abstract class Logistics
{
    public abstract ITransport CreateTransport();

    public string PlanDelivery()
    {
        var transport = CreateTransport();
        var result = transport.Deliver();
        return result;
    }
}
