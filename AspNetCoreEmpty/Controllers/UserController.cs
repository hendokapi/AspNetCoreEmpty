using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreEmpty.Controllers
{
    public class UserController : Controller
    {
        public string Index()
        {
            return "sono la index degli users";
        }

        [HttpGet]
        public string Show(int? id)
        {
            if (id.HasValue)
            {
                return "User with id: " + id;
            }
            return "No value for id";
        }
    }
}
