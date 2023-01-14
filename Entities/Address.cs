namespace Final_Exam.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int FlatNumber { get; set; }
        public Address() { }
        public Address(string city, string street, int housenumber, int flatnumber)
        {
            City = city;
            Street = street;
            HouseNumber = housenumber;
            FlatNumber = flatnumber;
        }
    }
}
