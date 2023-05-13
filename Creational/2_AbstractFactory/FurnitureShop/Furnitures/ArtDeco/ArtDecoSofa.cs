using _2_AbstractFactory.FurnitureShop.Factory;

namespace _2_AbstractFactory.FurnitureShop.Furnitures.ArtDeco
{
    internal class ArtDecoSofa : ISofaFurniture
    {
        public string Category()
        {
            return "This is art deco sofa category";
        }

        public string NoOfSeats()
        {
            return "This is art deco sofa with 4 seats";
        }
    }
}
