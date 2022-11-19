using AuthenticationProject.Models.Data;
using AuthenticationProject.Models.Entities;
using System.Linq;
using System.Web.Helpers;
using System.Web.Http;

namespace AuthenticationProject.Controllers
{
    public class RegistrationsController : ApiController
    {
        IInformationRepo repo=new InformationRepo();

        [HttpGet]
        [Route("api/Registrations/email/{email}")]
        public IHttpActionResult GetInformation(string email)
        {
            var info = repo.GetAll().Where(p => p.Email.Equals(email+".com"));
            if (info.Count() == 0)
                return BadRequest("given email not present in database");
            else
                return Ok(info);
        }

        [HttpGet]
        [Route("api/Registrations")]
        public IHttpActionResult GetAll()
        {
            var info = repo.GetAll();
            if (info == null)
                return BadRequest("given data is present in database");
            else
                return Ok(info);
        }

        [HttpPost]
        [Route("api/Registrations")]
        public IHttpActionResult PostInformation(LogInTable information)
        {
            if (!ModelState.IsValid)
                return BadRequest("invalid input");
            repo.postSignUpInformation(information);
            return Created($"api/Registrations/{information.LogInTableId}", information);
        }
    }
}
