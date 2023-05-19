using CrudAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace CrudAPI.Controllers
{
    [ApiController]
    [Route("/api/contact")]
    public class ContactController : Controller
    {
        private readonly ContactsAPIdbContext dbContext;

        public ContactController( ContactsAPIdbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult GetAllContact()
        {
            return Ok(dbContext.Contacts.ToList());

        }
    }
}
