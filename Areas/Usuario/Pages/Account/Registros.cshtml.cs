using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Paginas_Razor.Areas.Usuario.Pages.Account
{
    public class RegistrosModel : PageModel
    {
        //public string data { get; set; }
        //captura la información cada que se envia 
        public void OnGet(string data)
        {
            //this.data = data;
        }
        [BindProperty]
        public InputModel Input { get; set; }// "Input" permite acceder a las propiedades del modelo.
        public class InputModel
        {
            [Required]//no puede ser nulo
            [Display(Name ="Name")]//lo que el usuario visualiza en la pagina
            public string Name { get; set; }//campo dela base de datos

            [Required]
            [EmailAddress]//propiedad que define que es uncorreo
            [Display(Name = "Mail")]
            public string Mail { get; set; }

            [Required]
            [DataType(DataType.Password)]//da formato de contraseña al campo ******
            [Display(Name ="Contraseña")]
            [StringLength(100, ErrorMessage ="El numero de caracteres de {0} debe ser al menos {2}",MinimumLength =6)]//limita los caracteres que el usuario puede usar
            public string Password { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Compare("Password", ErrorMessage ="The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
        }
        //IActionResult retorna la pagina
        public IActionResult OnPost()//obtener informacion de la pagina usando (method post)
        {
            //se usa (Input) por el InputModel que se uso del model y de esa forma usar sus propiedades.
            var data = Input;//pasar la informacion de Input a data.
            return Page();
        }
    }
}
