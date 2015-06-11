using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace punto.Models
{
    public partial class tbevento
    {
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////
        /// JHGJHGJHGJHGJKGJKGJKGJKG
        /// CAMBIO
        /// </summary>
       [MetadataType(typeof(itbevento))]
        public partial class itbevento
       {
        public void prueba() {
            //this.estado = 1*5;
        }
    }
       public interface itevento {
           [Required]//deve tener algo de informacion
           object estado { get; set; }
           [MinLength(2)]//debe tener por lo menos dos caracteres
           object titulo { get; set; }
           [Key]//indicamos que es la llave de la tabla
           object idevento { get; set; }
       }
    }

}

