using BusinessLogicLayer;
using Microsoft.AspNetCore.Mvc;

namespace PresenttationLayer.MVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerServices _customerServices;
        public CustomerController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        public async Task<IActionResult> Index()
        {
            var customer = await _customerServices.GetCustomers();
            return View(customer);
        }
    }
}
