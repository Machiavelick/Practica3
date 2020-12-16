using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practica3.Models
{
    public class Registro
    {
        public int Id { get; set; }

        [Required]
        
        [Display(Name="Nombre del producto")]
        public string Nombre { get; set; }
        
        [Display(Name="URL de la imagen")]
         public string Url { get; set; }
         
        [Display(Name="Descripcion de la publicacion")]
        public string Descripcion { get; set; }

        
        [Display(Name="Precio a pagar")]
        public ICollection<Registro> Registros { get; set; }

        [Column(TypeName="decimal(5,2)")]
        public decimal? Precio { get; set; }
        
        [Display(Name="Celular de contacto")]
         public string Celular { get; set; }
         
        [Display(Name="Lugar de compra")]
          public string Lugar { get; set; }
          
        [Display(Name="Nombre de usuario")]
           public string NombreUsuario { get; set; }

    }
}