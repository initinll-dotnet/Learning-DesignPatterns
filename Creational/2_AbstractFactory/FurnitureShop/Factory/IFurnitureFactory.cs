namespace _2_AbstractFactory.FurnitureShop.Factory;

public interface IFurnitureFactory
{
    IChairFactory CreateChair();
    ISofaFurniture CreateSofa();
}
