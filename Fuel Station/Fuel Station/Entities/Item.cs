namespace Fuel_Station.Entities
{
    public class Item
    {
        public Item()
        {

        }
       
        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ItemTypeEnum ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }


    }
    public enum ItemTypeEnum
    {
        Fuel,
        Product,
        Service
    }
}
