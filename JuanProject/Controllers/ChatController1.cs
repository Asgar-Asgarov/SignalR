using Microsoft.AspNetCore.Mvc;

namespace JuanProject.Controllers
{
    public class ChatController1 : Controller
    {
        public IActionResult Chat()
        {
            return View();
        }
    }
}
