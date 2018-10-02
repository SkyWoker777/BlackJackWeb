namespace BlackJack.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Rank = c.Int(nullable: false),
                        Dignity = c.Int(nullable: false),
                        Suit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GameSessions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlayerGameSession",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PlayerId = c.Guid(nullable: false),
                        GameSessionId = c.Guid(nullable: false),
                        Wins = c.Int(nullable: false),
                        Defeats = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GameSessions", t => t.GameSessionId, cascadeDelete: true)
                .ForeignKey("dbo.Players", t => t.PlayerId, cascadeDelete: true)
                .Index(t => t.PlayerId)
                .Index(t => t.GameSessionId);
            
            CreateTable(
                "dbo.Players",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlayerGameSession", "PlayerId", "dbo.Players");
            DropForeignKey("dbo.PlayerGameSession", "GameSessionId", "dbo.GameSessions");
            DropIndex("dbo.PlayerGameSession", new[] { "GameSessionId" });
            DropIndex("dbo.PlayerGameSession", new[] { "PlayerId" });
            DropTable("dbo.Players");
            DropTable("dbo.PlayerGameSession");
            DropTable("dbo.GameSessions");
            DropTable("dbo.Cards");
        }
    }
}
