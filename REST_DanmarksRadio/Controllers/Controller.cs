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
        // GET: api/DR/{id}
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult GetById(int id)
        {
            var dr = _repository.GetById(id);
            if (dr == null)
            {
                return NotFound();
            }
            return Ok(dr);
        }

    }
}
