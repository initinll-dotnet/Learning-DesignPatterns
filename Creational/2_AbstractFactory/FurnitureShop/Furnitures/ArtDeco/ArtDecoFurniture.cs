using _2_AbstractFactory.FurnitureShop.Factory;

namespace _2_AbstractFactory.FurnitureShop.Furnitures.ArtDeco;

internal class ArtDecoFurniture : IFurnitureFactory
{
    public IChairFactory CreateChair()
    {
        return new ArtDecoChair();
    }

    public ISofaFurniture CreateSofa()
    {
        return new ArtDecoSofa();
    }
}
