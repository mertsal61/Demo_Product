using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Demo_Product.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager customerManager = new CustomerManager(new Efcustomerdal());
        public IActionResult Index()
        {
            var values = customerManager.GetCustomerListwithjob();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddCustomer()
        {
            jobmanager Jobmanager = new jobmanager(new efjobdal());
            List<SelectListItem> values = (from x in Jobmanager.GetList() select new SelectListItem
            {
                Text=x.JobName,
                Value=x.JobId.ToString()
            }).ToList();    
            ViewBag.v=values;
            return View();
        }
        [HttpPost]
        public IActionResult addcustomer(Customer p)
        {
            Customervalidator validationRules = new Customervalidator();
            ValidationResult results = validationRules.Validate(p);
            if (results.IsValid)
            {
                customerManager.insert(p);
                return RedirectToAction("index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
        }
        public IActionResult deletecustomer(int id)

        {
            var value = customerManager.getbyid(id);
            customerManager.delete(value);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult updatecustomer(int id)
        {
            var value=customerManager.getbyid(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult updatecustomer(Customer p)
        {
            customerManager.update(p);
            return RedirectToAction("index");
        }
        
    }
}
