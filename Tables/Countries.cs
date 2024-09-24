namespace ConsoleApp5.Tables
{
    public class Countries
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Cityes> Cityes { get; set; }



    }
}
