using Microsoft.AspNetCore.Mvc;
using MvcApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp2.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeRepository _employeeRepository;
        public EmployeeController(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public string MyMethod()
        {
            return "I pink up the phone and say yellow!";
        }
        public IActionResult Index()
        {
            //Some/Index.cshtml
            //return View();

            //galima issikviesti ir is home 
            return View("~/Views/Kebab/Index.cshtml");
        }
        public IActionResult List()
        {
            return View(_employeeRepository.GetAll());
        }
        public IActionResult Delete(int? id)
        {
            //if(id == null)
            //{
            //    return NotFound(); //404
            //}
            //if (_employeeRepository.DeleteById((int)id))
            //    return RedirectToAction("List");
            //else
            //    return NotFound();
            
            //ternary version
            return (id == null || !_employeeRepository.DeleteById((int)id))
                ? NotFound()
                : RedirectToAction("List");

            // cia naudojojm, kai kontroleryje buvo listas
            //var employeeToDelete = _employees.Find(e => e.Id == id);
            //if(_employees.Remove(employeeToDelete))
            //{
            //    //return Ok(); //200
            //    //return View("List", _employees); //permeta i kita puslapi, o vaiduoja kita. refreshinuys 500 error
            //    return RedirectToAction("List");
            //}
            //else
            //{
            //    return NotFound(); //404
            //}
        }
    }
}
