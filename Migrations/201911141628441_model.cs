namespace EvalSymfony.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class model : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomClient = c.String(maxLength: 50),
                        IdClient = c.String(nullable: false, maxLength: 50),
                        MotDePasseClient = c.String(nullable: false, maxLength: 50),
                        EmailClient = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jeus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomJeu = c.String(nullable: false, maxLength: 50),
                        PlateformeJeu = c.String(nullable: false, maxLength: 50),
                        StatutStock = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Client = c.String(nullable: false, maxLength: 50),
                        Jeu = c.String(nullable: false, maxLength: 50),
                        DateReservation = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.JeuClients",
                c => new
                    {
                        Jeu_Id = c.Int(nullable: false),
                        Client_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Jeu_Id, t.Client_Id })
                .ForeignKey("dbo.Jeus", t => t.Jeu_Id, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.Client_Id, cascadeDelete: true)
                .Index(t => t.Jeu_Id)
                .Index(t => t.Client_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JeuClients", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.JeuClients", "Jeu_Id", "dbo.Jeus");
            DropIndex("dbo.JeuClients", new[] { "Client_Id" });
            DropIndex("dbo.JeuClients", new[] { "Jeu_Id" });
            DropTable("dbo.JeuClients");
            DropTable("dbo.Reservations");
            DropTable("dbo.Jeus");
            DropTable("dbo.Clients");
        }
    }
}
