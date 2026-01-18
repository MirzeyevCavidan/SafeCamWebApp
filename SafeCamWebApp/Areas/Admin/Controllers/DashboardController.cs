using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SafeCamWebApp.Areas.Admin.Controllers;

[Authorize(Roles = "Admin,Moderator")]
[Area("Admin")]
public class DashboardController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}