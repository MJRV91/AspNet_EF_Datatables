using DatatablesAjaxEf.Data;
using DatatablesAjaxEf.Data.Entities;
using DatatablesAjaxEf.IServices;
using Microsoft.EntityFrameworkCore;

namespace DatatablesAjaxEf.Services
{
    public class AlumnoService : IAlumnoServices
    {
        private readonly DataContext _context;
        public AlumnoService(DataContext context)
        {
            _context = context;
        }
        public async Task<string> Delete(int id)
        {
            var alumno = await _context.Alumnos.FirstOrDefaultAsync(x => x.id_alumno == id);
            if (alumno != null)
            {
                _context.Alumnos.Remove(alumno);
                _context.SaveChanges();
            }
            return "Delete";
        }

        public async Task<List<AlumnosEnty>> GetAll()
        {
            return await _context.Alumnos.ToListAsync();
        }

        public void Save(AlumnosEnty oAlumno)
        {
            _context.Alumnos.Add(oAlumno);
            _context.SaveChanges();
        }

        public void Update(AlumnosEnty oAlumno)
        {
           _context.Alumnos.Update(oAlumno);
            _context.SaveChanges();
        }
    }
}
