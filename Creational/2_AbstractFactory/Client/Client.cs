using _2_AbstractFactory.FurnitureShop.Factory;
using _2_AbstractFactory.FurnitureShop.Furnitures.ArtDeco;
using _2_AbstractFactory.FurnitureShop.Furnitures.Modern;

namespace _2_AbstractFactory.Client;

public class Client
{
    public void Main()
    {
        ClientCode(new ModernFurniture());
        ClientCode(new ArtDecoFurniture());
    }

    public void ClientCode(IFurnitureFactory furnitureFactory)
    {
        var chair = furnitureFactory.CreateChair();
        var sofa = furnitureFactory.CreateSofa();

        Console.WriteLine($"Client: I am not aware of creator's class but it still works -");
        Console.WriteLine($"Chair Category : {chair.Category()}");
        Console.WriteLine($"Chair Material : {chair.Material()}");
        Console.WriteLine($"Sofa Material  : {sofa.Category()}");
        Console.WriteLine($"Sofa Seats     : {sofa.NoOfSeats()}");
    }
}
