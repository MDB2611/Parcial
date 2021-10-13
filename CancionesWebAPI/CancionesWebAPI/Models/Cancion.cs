using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CancionesWebAPI.Models
{
    public class Cancion
    {
        [Key]
        public string Name { get; set; }
        [Required(ErrorMessage = "El autor es requerido")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "El nombre del autor debe tener entre 2 y 200 caracteres")]
        [Display(Name = "Nombre completo del autor")]
        public string Author { get; set; }
        [Display(Name = "Letra de la canción")]
        public string Lyrics { get; set; }
        [Required]
        [Url]
        [Display(Name = "Link de Youtube")]
        public string Link { get; set; }

    }
}
