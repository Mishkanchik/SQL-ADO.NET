namespace ClassLibrary1.Entities
{
    public class Workers
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string SurName { get; set; }
        public decimal Salary { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Positions Positions { get; set; }
        public int PositionId { get; set; }

        public Shops Shops { get; set; }
        public int ShopsId { get; set; }



    }
}
