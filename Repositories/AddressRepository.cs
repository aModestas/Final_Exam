using Final_Exam.DB;
using Final_Exam.Entities;
using Final_Exam.Interfaces;

namespace Final_Exam.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly ApplicationDBContext _context;
        private readonly List<Address> _addresses=new List<Address>();
        public AddressRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public Address AddNewAddress(AddressDTO address)
        {
            var newAddress = new Address
            {
                City = address.City,
                Street = address.Street,
                HouseNumber = address.HouseNumber,
                FlatNumber = address.FlatNumber,
            };
            _context.Addresses.Add(newAddress);
            _context.SaveChanges();
            return newAddress;
        }

        public Address GetAddress(int id)
        {
            throw new NotImplementedException();
        }

        public List<Address> GetAddresses()
        {
            return _context.Addresses.ToList();
        }
    }
}
