using _2_AbstractFactory.FurnitureShop.Factory;

namespace _2_AbstractFactory.FurnitureShop.Furnitures.Modern;

public class ModernChair : IChairFactory
{
    public string Category()
    {
        return "This is modern chair category";
    }

    public string Material()
    {
        return "This is modern material for modern chair";
    }
}
