using DatatablesAjaxEf.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DatatablesAjaxEf.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<AlumnosEnty> Alumnos {get; set;}
    }
}
