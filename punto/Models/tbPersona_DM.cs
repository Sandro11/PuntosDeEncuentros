using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace punto.Models
{
    [MetadataType(typeof(tbpersonaDM))]
    public partial class tbpersona
    {
 
        public class tbpersonaDM
        {
            [Required]
            public object nombre { get; set; }
            [Required]
            public object paterno { get; set; }
            [Required]
            public object materno { get; set; }
            [Range(60000, 150000000)]
            public object ci { get; set; }
            [DataType(DataType.DateTime)]
            public object fechanac;
            [DataType(DataType.DateTime)]
            public object fechacreacion;
            [DataType(DataType.DateTime)]
            public object fechamodificacion;
            [Required]
            public object estado { get; set; }
            [Key]
            public object tbusuario { get; set; }
              
        }
    }
}