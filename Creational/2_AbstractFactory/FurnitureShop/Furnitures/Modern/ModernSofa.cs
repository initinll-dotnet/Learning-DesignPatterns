using _2_AbstractFactory.FurnitureShop.Factory;

namespace _2_AbstractFactory.FurnitureShop.Furnitures.Modern;

public class ModernSofa : ISofaFurniture
{
    public string Category()
    {
        return "This is modern sofa category";
    }

    public string NoOfSeats()
    {
        return "This is modern sofa with 4 seats";
    }
}
