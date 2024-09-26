namespace ClassLibrary1.Entities
{
    public class Cityes
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Shops> Shops { get; set; }

        public Countries Countries { get; set; }
        public int CountriesId { get; set; }


    }
}
