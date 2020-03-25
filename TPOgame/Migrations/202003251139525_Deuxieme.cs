namespace TPOgame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Deuxieme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buildings",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        name = c.String(),
                        level = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Planet_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Planets", t => t.Planet_Id)
                .Index(t => t.Planet_Id);
            
            CreateTable(
                "dbo.Planets",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        name = c.String(),
                        caseNb = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Resources", "Planet_Id", c => c.Long());
            AlterColumn("dbo.Resources", "name", c => c.String(maxLength: 20));
            AlterColumn("dbo.SolarSystems", "name", c => c.String(maxLength: 20));
            CreateIndex("dbo.Resources", "Planet_Id");
            AddForeignKey("dbo.Resources", "Planet_Id", "dbo.Planets", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Resources", "Planet_Id", "dbo.Planets");
            DropForeignKey("dbo.Buildings", "Planet_Id", "dbo.Planets");
            DropIndex("dbo.Resources", new[] { "Planet_Id" });
            DropIndex("dbo.Buildings", new[] { "Planet_Id" });
            AlterColumn("dbo.SolarSystems", "name", c => c.String());
            AlterColumn("dbo.Resources", "name", c => c.String());
            DropColumn("dbo.Resources", "Planet_Id");
            DropTable("dbo.Planets");
            DropTable("dbo.Buildings");
        }
    }
}
