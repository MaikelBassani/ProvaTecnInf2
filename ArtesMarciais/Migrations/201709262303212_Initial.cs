namespace ArtesMarciais.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Faixa(Nome, Grau) VALUES ('Branca', '6k')");
            Sql("INSERT INTO Faixa(Nome, Grau) VALUES ('Amarela', '5k')");
            Sql("INSERT INTO Faixa(Nome, Grau) VALUES ('Roxa', '4k')");
            Sql("INSERT INTO Faixa(Nome, Grau) VALUES ('Verde', '3k')");
            Sql("INSERT INTO Faixa(Nome, Grau) VALUES ('Azul', '2k')");
            Sql("INSERT INTO Faixa(Nome, Grau) VALUES ('Preta', '1k')");
        }
        
        public override void Down()
        {
        }
    }
}
