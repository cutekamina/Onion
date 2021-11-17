using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Bal;
using Bal.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnionAr.Models;
using ViewModel.ViewModel;

namespace OnionAr.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudents _IStudents;

        public HomeController(ILogger<HomeController> logger, IStudents IStudents)
        {
            _logger = logger;
            _IStudents = IStudents;
        }

        public IActionResult Index()
        {
            return View();
        }
        public ActionResult StudentForm()
        {
            return View();
        }
        public ActionResult StudentFormWithAjex()
        {
            return View();
        }
        public int Add(VmStudent obj)
        {
            try
            {
                int i = 0;
                bool status = _IStudents.AddStudent(obj);
                if (status == true)
                {
                    TempData["msg"] = "datasaved";
                }
                else
                {
                    TempData["msg"] = "error ";
                }
            return i;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ActionResult StudentDetatils(VmStudent obj)
        {
            try
            {
                if(obj!=null)
                {
                 bool status = _IStudents.AddStudent(obj);
                 if(status==true)
                    {
                        TempData["msg"] = "datasaved";
                    }
                    else
                    {
                        TempData["msg"] = "error ";
                    }
                }
                else
                {
                    TempData["msg"] = "something wrong ";
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return View("StudentForm");
        }
        public  ActionResult StudentList()
        {
            try
            {
                List<VmStudent> lst = new List<VmStudent>();
                //lst = await _IStudents.Get();
                lst = _IStudents.Get();
                return View(lst);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public ActionResult DeleteByid(int id )
        {
            try
            {
                bool status = _IStudents.DeleteByid(id);
                if (status == true)
                {
                    TempData["msg"] = "Data Delete Succesfully";
                }
                else
                {
                    TempData["msg"] = "ID not found";
                }
                return RedirectToAction("StudentList");
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
