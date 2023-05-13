using _2_AbstractFactory.FurnitureShop.Factory;

namespace _2_AbstractFactory.FurnitureShop.Furnitures.ArtDeco;

public class ArtDecoChair : IChairFactory
{
    public string Category()
    {
        return "This is art deco chair category";
    }

    public string Material()
    {
        return "This is art deco material for art deco chair";
    }
}
