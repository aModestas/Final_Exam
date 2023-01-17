using Final_Exam.DB;
using Final_Exam.Entities;
using Final_Exam.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Final_Exam.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddressController : Controller
    {
        private readonly IAddressRepository _addressRepository;
        public AddressController(IAddressRepository addressRepository)
        {
            _addressRepository = addressRepository;
        }
        [HttpGet]
        public List<Address> GetAddresses()
        {
            return _addressRepository.GetAddresses();
        }

        [HttpPost]
        public Address Add([FromBody] AddressDTO address)
        {
            return _addressRepository.AddNewAddress(address);
        }
    }
}
