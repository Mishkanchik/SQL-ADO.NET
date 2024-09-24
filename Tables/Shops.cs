namespace ConsoleApp5.Tables
{
    public class Shops
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public int ParkingArea { get; set; }
        public ICollection<Workers> Workers { get; set; }

        public Cityes Cityes { get; set; }
        public int CityId { get; set; }

        public ICollection<Products> Products { get; set; }

    }
}
