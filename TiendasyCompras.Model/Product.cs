namespace TiendasyCompras.Model
{
    public class Product
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ProductTypeId { get; set; }
        public string Brand { get; set; }
        public string Price { get; set; }
        public int Stock { get; set; }
    }
}