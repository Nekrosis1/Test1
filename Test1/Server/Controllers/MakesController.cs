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
    public class MakesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public MakesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: /Makes
        [HttpGet]
        public async Task<IActionResult> GetMakes()
        {
            //if (_unitOfWork.Makes == null)
            //{
            //    return NotFound();
            //}
            var makes = await _unitOfWork.Makes.GetAll();
            return Ok(makes);
        }

        // GET: /Makes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMake(int id)
        {
            //if (_unitOfWork.Makes == null)
            //{
            //    return NotFound();
            //}
            var make = await _unitOfWork.Makes.Get(q => q.Id == id);

            if (make == null)
            {
                return NotFound();
            }

            return Ok(make);
        }

        // PUT: /Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMake(int id, Make make)
        {
            if (id != make.Id)
            {
                return BadRequest();
            }
            _unitOfWork.Makes.Update(make);

            try
            {
                await _unitOfWork.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await MakeExists(id))
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

        // POST: /Makes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Make>> PostMake(Make make)
        {
            //if (_context.Makes == null)
            //{
            //    return Problem("Entity set 'ApplicationDbContext.Makes'  is null.");
            //}
            await _unitOfWork.Makes.Insert(make);
            await _unitOfWork.Save();

            return CreatedAtAction("GetMake", new { id = make.Id }, make);
        }

        // DELETE: /Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMake(int id)
        {
            //if (_context.Makes == null)
            //{
            //    return NotFound();
            //}
            var make = await _unitOfWork.Makes.Get(q => q.Id == id);
            if (make == null)
            {
                return NotFound();
            }
            await _unitOfWork.Makes.Delete(id);
            await _unitOfWork.Save();
            return NoContent();
        }

        private async Task<bool> MakeExists(int id)
        {
            var make = await _unitOfWork.Makes.Get(q => q.Id == id);
            return make == null; //should this be "!="?
        }
    }
}
