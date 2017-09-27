namespace ArtesMarciais.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class valores2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Aluno(nome, cpf,FaixaId,TipodeAssociacaoId) VALUES ('Martim Castro Ribeiro', '158.778.735-04','1','6')");
            Sql("INSERT INTO Aluno(nome, cpf,FaixaId,TipodeAssociacaoId) VALUES ('Lucas Alves Melo', '916.749.332-74','4','8')");
            Sql("INSERT INTO Aluno(nome, cpf,FaixaId,TipodeAssociacaoId) VALUES ('Breno Castro Carvalho', '454.019.800-94','2','7')");
            Sql("INSERT INTO Aluno(nome, cpf,FaixaId,TipodeAssociacaoId) VALUES ('Laura Cardoso Rocha', '361.089.665-56','7','9')");
        }
        
        public override void Down()
        {
        }
    }
}
