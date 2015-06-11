using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace punto.Models
{
  
        [MetadataType(typeof(tbpagoDM))]
        public partial class tbpago  //nombre de la tabla
        {
            //void nn() { this.}
            public class tbpagoDM
            {
                [Required]
                public object nombre { get; set; }
                [StringLength(15),Required]
                public object imagen { get; set; }
                [Range(typeof(DateTime), "1/2/2004", "3/4/2020")]
                public object fechacreacion;
                [Range(typeof(DateTime), "1/2/2004", "3/4/2020")]
                public object fechamodificacion;
                public object estado { get; set; }
                public object tbpagolugares { get; set; }


                //[Range(0, 9999)]
                //public object Weight { get; set; }
                
            }

        }
    }

