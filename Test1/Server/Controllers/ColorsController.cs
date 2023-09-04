using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test1.Server.Data;
using Test1.Server.IRepository;
using Test1.Server.Repository;
using Test1.Shared.Domain;

namespace Test1.Server.Controllers
{
    //[Authorize]
    [Route("[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ColorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Colors
        [HttpGet]
        public async Task<IActionResult> GetColors()
        {
            var colors = await _unitOfWork.Colors.GetAll();
            return Ok(colors);
        }

        // GET: /Colors/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetColor(int id)
        {
            var color = await _unitOfWork.Colors.Get(q => q.Id == id);

            if (color == null)
            {
                return NotFound();
            }

            return Ok(color);
        }

        // POST: /Colors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Color>> PostColor(Color color)
        {

            await _unitOfWork.Colors.Insert(color);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetColor", new { id = color.Id }, color);
        }

        // PUT: /Colors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColor(int id, Color color)
        {
            if (id != color.Id)
            {
                return BadRequest();
            }
            _unitOfWork.Colors.Update(color);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ColorExists(id))
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

        // DELETE: /Colors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColor(int id)
        {
            var color = await _unitOfWork.Colors.Get(q => q.Id == id);
            if (color == null)
            {
                return NotFound();
            }
            await _unitOfWork.Colors.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }

        private async Task<bool> ColorExists(int id)
        {
            var color = await _unitOfWork.Colors.Get(q => q.Id == id);
            return color == null; //should this be "!="?
        }
    }
}
