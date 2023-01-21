using Final_Exam.Entities;

namespace Final_Exam.DB
{
    public class PersonDTO
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int PersonCode { get; set; }
        public int TelNumber { get; set; }
        public string Email { get; set; }
        public byte[] Picture { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public int FlatNumber { get; set; }
        public int UserId { get; set; }
    }
}
