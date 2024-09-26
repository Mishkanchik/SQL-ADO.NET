namespace ClassLibrary1.Entities
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }
        public float Discount { get; set; }
        public int Quantity { get; set; }
        public bool IsinStock { get; set; }

        public Categories Categories { get; set; }

        public int CategoriesId { get; set; }

        public ICollection<Shops> Shops { get; set; }

        public ProductDetail? ProductDetail { get; set; }


    }
}
