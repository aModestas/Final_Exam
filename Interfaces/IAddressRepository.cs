using Final_Exam.DB;
using Final_Exam.Entities;

namespace Final_Exam.Interfaces
{
    public interface IAddressRepository
    {
        List<Address> GetAddresses();
    }
}
