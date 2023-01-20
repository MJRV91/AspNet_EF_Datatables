using DatatablesAjaxEf.Data.Entities;
using DatatablesAjaxEf.IServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DatatablesAjaxEf.Apis
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiAlumnosController : ControllerBase
    {
        IAlumnoServices _alumnos;
        public ApiAlumnosController(IAlumnoServices alumnos)
        {
            _alumnos = alumnos;
        }
        // GET: api/<ApiAlumnosController>
        [HttpGet]
        public async Task<List<AlumnosEnty>> GetAll()
        {
            return await _alumnos.GetAll();
        }

      
        // POST api/<ApiAlumnosController>
        [HttpPost]
        public void Post([FromForm] AlumnosEnty oAlumno)
        {
            if (oAlumno.id_alumno == 0)
            {
                _alumnos.Save(oAlumno);
            }
            else
            {
                _alumnos.Update(oAlumno);
            }
        }

      
        // DELETE api/<ApiAlumnosController>/5
        [HttpDelete("{id}")]
        public async Task<string> Delete(int id)
        {
            return await _alumnos.Delete(id);
        }
    }
}
