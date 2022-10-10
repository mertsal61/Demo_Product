using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class ProductController1 : Controller
    {
        ProductManager productManager = new ProductManager(new EfproductDal());
        public IActionResult Index()
        {
            var values=productManager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            ProductValidator validationRules = new ProductValidator();
            ValidationResult results=validationRules.Validate(p);
            if(results.IsValid)
            {
                productManager.insert(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
        public IActionResult Deleteproduct(int id)
        {
            var value = productManager.getbyid(id);
            productManager.delete(value);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Updateproduct(int id)
        {
            var value = productManager.getbyid(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Updateproduct(Product p)
        {
            
            productManager.update(p);
            return RedirectToAction("index");
        }

    }
}
