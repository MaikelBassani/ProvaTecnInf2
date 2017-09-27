using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ArtesMarciais.Models
{
    [Table("dbo.Aluno")] 
    public class Aluno
    {
         public int id { get; set; }
         public String nome { get; set; }
         public String cpf { get; set; }
         public Faixa faixa { get; set; }
         public int FaixaId { get; set; }
         public TipodeAssociacao TipodeAssociacao { get; set; }
         public int TipodeAssociacaoId { get; set; }
    }
}