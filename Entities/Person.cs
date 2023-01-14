namespace Final_Exam.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int PersonCode { get; set; }
        public int TelNumber { get; set; }
        public string Email { get; set; }
        public byte[] Picture { get; set; }
        public Address Address { get; set; }
        public Person() { }
        public Person(string name, string lastname, int personcode, int telnumber, string email, byte[] picture, Address address)
        {
            Name = name;
            Lastname = lastname;
            PersonCode = personcode;  
            TelNumber = telnumber;
            Email = email;
            Picture = picture;
            Address = address;  
        }

    }
}
