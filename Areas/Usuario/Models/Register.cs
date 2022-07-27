using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Paginas_Razor.Areas.Usuario.Models
{
    public class Register
    {
        //[Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informacion necesaria")]//no puede ser nulo y se puede personalizar por que es una clase que tienen sobre carga de metodos
        [Display(Name = "Name")]//lo que el usuario visualiza en la pagina
        public string Name { get; set; }//campo dela base de datos

        [Required(ErrorMessage = "Informacion necesaria")]
        [EmailAddress]//propiedad que define que es uncorreo
        [Display(Name = "Mail")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Informacion necesaria")]
        [DataType(DataType.Password)]//da formato de contraseña al campo ******
        [Display(Name = "Contraseña")]
        [StringLength(100, ErrorMessage = "El numero de caracteres de {0} debe ser al menos {2}", MinimumLength = 6)]//limita los caracteres que el usuario puede usar
        public string Password { get; set; }

        [Required(ErrorMessage = "Informacion necesaria")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
