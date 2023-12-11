using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Modelos
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El nombre es requerido")]
        [MaxLength(60, ErrorMessage ="El nombre no debe superar los 60 Caracteres")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La descripción es requerida")]
        [MaxLength(100, ErrorMessage = "La descripción no debe superar los 100 Caracteres")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El estado es requerido")]
        public bool Estado { get; set; }
    }
}
