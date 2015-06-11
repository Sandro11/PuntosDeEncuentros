using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace punto.Models
{
    [MetadataType(typeof(tbusuarioDM))]
    public partial class tbusuario
    {
        public class tbusuarioDM
        {
            [Required]
            public object login { get; set; }
            [Required]
            public object pass { get; set; }
            [Required]
            public object fid { get; set; }
            [EmailAddress]
            public object gemail { get; set; }
           
            [DataType(DataType.DateTime)]
            public object creado;
            [DataType(DataType.DateTime)]
            public object fechacreacion;
            [DataType(DataType.DateTime)]
            public object fechamodificacion;
            [Required]
            public object estado { get; set; }
            [Key]
            public object tbpersona { get; set; }
            [Key]
            public object tbvotousuario { get; set; }

        }
    }
}