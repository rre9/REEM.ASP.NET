using ClinicApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClinicApp.Controllers;

public class DoctorController : Controller
{
    public IActionResult Index()
    {
        return View(Constants.Doctors);
    }

    public IActionResult Details()
    {
        return View();
    }
}

