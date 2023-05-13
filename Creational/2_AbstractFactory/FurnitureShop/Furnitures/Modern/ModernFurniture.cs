using _2_AbstractFactory.FurnitureShop.Factory;

namespace _2_AbstractFactory.FurnitureShop.Furnitures.Modern;

public class ModernFurniture : IFurnitureFactory
{
    public IChairFactory CreateChair()
    {
        return new ModernChair();
    }

    public ISofaFurniture CreateSofa()
    {
        return new ModernSofa();
    }
}
