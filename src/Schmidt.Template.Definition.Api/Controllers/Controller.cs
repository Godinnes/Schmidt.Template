using Microsoft.AspNetCore.Mvc;

namespace Schmidt.Template.Definition.Api.Controllers
{
    public class Controller
    {
        protected IActionResult Ok(object obj)
        {
            return new OkObjectResult(obj);
        }
    }
}
