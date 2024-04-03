namespace Backend.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ProfilePhoto { get; set; }
        public string ShortBibliografy { get; set; }
        public string Bibliografy { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public string DateBorn { get; set; }
        public string Province { get; set; }
        public string Municipe { get; set; }
        public string Genre { get; set; }
        public string SexualOrientation { get; set; }
        public string Profession { get; set; }
        public string Searching { get; set; }
        public string[] Interests { get; set; }
        public string[] Images { get; set; }
    }
}