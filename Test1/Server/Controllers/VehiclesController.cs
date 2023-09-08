using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test1.Server.IRepository;
using Test1.Shared.Domain;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public VehiclesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: /vehicles
        [HttpGet]
        public async Task<IActionResult> GetVehicles()
        {
            //var includes = new List<string> { "Make", "Model", "Color" };
            var vehicles = await _unitOfWork.Vehicles.GetAll(includes: q =>
            q.Include(x => x.Color).Include(x => x.Make).Include(x => x.Model));
            return Ok(vehicles);
        }

        // GET /vehicles/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehicles(int id)
        {
            //var includes = new List<string> { "Make", "Model", "Color", "Bookings" };

            var vehicles = await _unitOfWork.Vehicles.Get(q => q.Id == id, includes: q =>
			 q.Include(x => x.Color).Include(x => x.Make).Include(x => x.Model).Include(x => x.Bookings));
			if (vehicles == null)
            {
                return NotFound();
            }

            return Ok(vehicles);
        }

        // POST /vehicles
        [HttpPost]
        public async Task<ActionResult<Vehicle>> PostVehicle(Vehicle vehicle)
        {

            await _unitOfWork.Vehicles.Insert(vehicle);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GeVehicle", new { id = vehicle.Id }, vehicle);
        }

        // PUT /vehicles/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicle(int id, Vehicle vehicle)
        {
            if (id != vehicle.Id)
            {
                return BadRequest();
            }
            _unitOfWork.Vehicles.Update(vehicle);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await VehicleExists(id))
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

        // DELETE /vehicles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            var vehicle = await _unitOfWork.Vehicles.Get(q => q.Id == id);
            if (vehicle == null)
            {
                return NotFound();
            }
            await _unitOfWork.Vehicles.Delete(id);
            await _unitOfWork.Save(HttpContext);
            return NoContent();
        }
        private async Task<bool> VehicleExists(int id)
        {
            var vehicle = await _unitOfWork.Vehicles.Get(q => q.Id == id);
            return vehicle != null;
        }
    }
}
