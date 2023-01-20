using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatatablesAjaxEf.Data.Entities
{
    [Table("Alumnos")]
    public class AlumnosEnty
    {
        [Key]
        public int id_alumno { get; set; }
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public int documento { get; set; }
    }
}
