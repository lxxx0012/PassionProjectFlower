namespace PassionProjectFlower.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class flower : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bouquets",
                c => new
                    {
                        BouquetId = c.Int(nullable: false, identity: true),
                        BouquetName = c.String(),
                        BouquetPrice = c.String(),
                        FlowerDescription = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BouquetId);
            
            CreateTable(
                "dbo.Flowers",
                c => new
                    {
                        FlowerId = c.Int(nullable: false, identity: true),
                        FlowerName = c.String(),
                        FlowerColor = c.String(),
                        FlowerPrice = c.Int(nullable: false),
                        FlowerPic = c.String(),
                    })
                .PrimaryKey(t => t.FlowerId);
            
            CreateTable(
                "dbo.Occasions",
                c => new
                    {
                        OccasionId = c.Int(nullable: false, identity: true),
                        OccasionName = c.String(),
                        OccasionDescription = c.String(),
                    })
                .PrimaryKey(t => t.OccasionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Occasions");
            DropTable("dbo.Flowers");
            DropTable("dbo.Bouquets");
        }
    }
}
