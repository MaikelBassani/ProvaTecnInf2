namespace ArtesMarciais.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Testeforced : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Alunoes", newName: "Aluno");
            RenameTable(name: "dbo.Faixas", newName: "Faixa");
            RenameTable(name: "dbo.TipodeAssociacaos", newName: "TipodeAssociacao");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.TipodeAssociacao", newName: "TipodeAssociacaos");
            RenameTable(name: "dbo.Faixa", newName: "Faixas");
            RenameTable(name: "dbo.Aluno", newName: "Alunoes");
        }
    }
}
