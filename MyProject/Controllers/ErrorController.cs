using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{StatusCode}")]
        public IActionResult HttpStatusCodeErrors(int statuscode)
        {
            switch (statuscode)
            {
                case 404:
                    ViewBag.StatusCode = "404:Not Found";
                    ViewData["ErrorMessage"] = "Sorry,resource you are could not found";
                    break;
                case 400:
                    ViewBag.StatusCode = "400:Bad Request";
                    ViewData["ErrorMessage"] = "Sorry,the requested could not be understand by the server or Invalid Url";
                    break;
                case 500:
                    ViewBag.StatusCode = "500:Internal Server Error";
                    ViewData["ErrorMessage"] = "Sorry, Internal Server Error. Please try After Some Time or Refresh The Page";
                    break;
            }
            return View();
        }
    }
}
