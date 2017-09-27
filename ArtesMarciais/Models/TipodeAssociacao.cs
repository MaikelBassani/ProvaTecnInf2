using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ArtesMarciais.Models
{
    [Table("dbo.TipodeAssociacao")] 
    public class TipodeAssociacao
    {
        public int id { get; set; }
        public String nome { get; set; }
        public int periodo { get; set; }
        public int mensalidade { get; set; }
    }
}