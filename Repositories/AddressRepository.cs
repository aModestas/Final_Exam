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
        public List<Address> GetAddresses()
        {
            return _context.Addresses.ToList();
        }
    }
}
