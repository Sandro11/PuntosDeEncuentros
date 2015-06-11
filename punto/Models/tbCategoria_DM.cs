using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace punto.Models
{
    [MetadataType(typeof(tbCategoria_DM))]
    public partial class tbpersona
    {
    public class tbCategoria_DM
    {
        [Required]
        public object nombre { get; set; }
        [Required]
        public object responsable { get; set; }
        [Required]
        public object padre { get; set; }
        [DataType(DataType.DateTime)]
        public object fechacreacion;
        [DataType(DataType.DateTime)]
        public object fechamodificacion;
        [Required]
        public object estado { get; set; }
        [Key]
        public object tbcalugar { get; set; }
    }
}
}