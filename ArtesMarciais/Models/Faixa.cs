using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ArtesMarciais.Models
{
    [Table("dbo.Faixa")] 
    public class Faixa
    {
        public int id { get; set; }
        public String nome { get; set; }
        public String grau { get; set; }

    }
}