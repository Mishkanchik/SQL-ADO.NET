namespace ConsoleApp5.Tables
{
    public class Positions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Workers> Workers { get; set; }





    }
}
