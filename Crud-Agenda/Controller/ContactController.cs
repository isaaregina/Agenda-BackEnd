using Microsoft.AspNetCore.Mvc;

namespace Crud_Agenda.Controller
{
    public class ContactController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
