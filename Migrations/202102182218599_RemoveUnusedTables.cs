namespace InputsOutputs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUnusedTables : DbMigration
    {
        public override void Up()
        {
            Sql("DROP VIEW IF EXISTS [dbo].[All]");
            RenameTable(name: "dbo.Sales", newName: "Data");
            AddColumn("dbo.Data", "Type", c => c.Int(nullable: false, defaultValue: 0));
            AlterColumn("dbo.Data", "SellerName", c => c.String(maxLength: 128));
            DropTable("dbo.Costs");
            DropTable("dbo.Returns");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Returns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Name = c.String(nullable: false, maxLength: 1024),
                        PriceRon = c.Int(),
                        PriceEuro = c.Int(),
                        PricePounds = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Costs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Name = c.String(nullable: false, maxLength: 1024),
                        PriceRon = c.Int(),
                        PriceEuro = c.Int(),
                        PricePounds = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Data", "SellerName", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Data", "Type");
            RenameTable(name: "dbo.Data", newName: "Sales");
        }
    }
}
