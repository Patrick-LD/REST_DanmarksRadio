using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassLibary;

namespace REST_DanmarksRadio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DRController : ControllerBase
    {
        private IRepository _repository;

        public DRController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: api/DR
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult GetAll()
        {
            return Ok(_repository.GetAll());
        }
    }
}
