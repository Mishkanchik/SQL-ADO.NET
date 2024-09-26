namespace ClassLibrary1.Entities
{
    public class Countries
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Cityes> Cityes { get; set; }



    }
}
