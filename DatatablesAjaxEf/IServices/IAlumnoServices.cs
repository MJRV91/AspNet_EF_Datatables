using DatatablesAjaxEf.Data.Entities;

namespace DatatablesAjaxEf.IServices
{
    public interface IAlumnoServices
    {
        Task<List<AlumnosEnty>> GetAll();
        void Save(AlumnosEnty oAlumno);
        void Update(AlumnosEnty oAlumno);
        Task<string> Delete(int id);

    }
}
