namespace ClassLibrary1.Entities
{
    public class Positions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Workers> Workers { get; set; }





    }
}
