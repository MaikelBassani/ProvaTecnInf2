namespace ArtesMarciais.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class valores : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TipodeAssociacao(Nome, Periodo,Mensalidade) VALUES ('Mensal', '1','140')");
            Sql("INSERT INTO TipodeAssociacao(Nome, Periodo,Mensalidade) VALUES ('Trimestral', '3','400')");
            Sql("INSERT INTO TipodeAssociacao(Nome, Periodo,Mensalidade) VALUES ('Semestral', '6','600')");
            Sql("INSERT INTO TipodeAssociacao(Nome, Periodo,Mensalidade) VALUES ('Anual', '12','1400')");
  
        }
        
        public override void Down()
        {
        }
    }
}
