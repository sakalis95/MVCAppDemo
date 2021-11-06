﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApp2.Controllers
{
    //[Authorize]
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
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

        [Authorize]
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
        public IActionResult Create(string name)
        {
            _employeeRepository.Create(name);
            return RedirectToAction("List");
        }
        public IActionResult Details(int? id)
        {
            return id == null
                    ? NotFound()
                    : View(_employeeRepository.GetById((int)id));
        }
        public IActionResult Update(int id, string name)
        {
            _employeeRepository.Update(id, name);
            return RedirectToAction("List");
        }
    }
}
