using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test1.Server.IRepository;
using Test1.Shared.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test1.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ModelsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: /Models
        [HttpGet]
        public async Task<IActionResult> GetModels()
        {
            var models = await _unitOfWork.Models.GetAll();
            return Ok(models);
        }

        // GET /Models/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetModels(int id)
        {
            var model = await _unitOfWork.Models.Get(q => q.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

        // POST /Models
        [HttpPost]
        public async Task<ActionResult<Model>> PostMake(Model model)
        {
            await _unitOfWork.Models.Insert(model);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetModel", new { id = model.Id }, model);
        }

        // PUT /Models/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModel(int id, Model model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }
            _unitOfWork.Models.Update(model);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE /Models/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModel(int id)
        {
            var model = await _unitOfWork.Models.Get(q => q.Id == id);
            if (model == null)
            {
                return NotFound();
            }
            await _unitOfWork.Makes.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }
        private async Task<bool> ModelExists(int id)
        {
            var model = await _unitOfWork.Models.Get(q => q.Id == id);
            return model == null; //should this be "!="?
        }
    }
}
