using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Demo_Product.Controllers
{
    public class JobController : Controller
    {
        jobmanager jobmanager = new jobmanager(new efjobdal());
        public IActionResult Index()
        {
            var values = jobmanager.GetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddJob()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddJob(Job p)
        {
            jobmanager.insert(p);
            return RedirectToAction("index");

        }
        public IActionResult Deletejob(int id)
        {
            var value = jobmanager.getbyid(id);
            jobmanager.delete(value);
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Updatejob(int id)
        {
            var value = jobmanager.getbyid(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Updatejob(Job p)
        {

            jobmanager.update(p);
            return RedirectToAction("index");
        }
    }
}
