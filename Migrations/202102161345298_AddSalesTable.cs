namespace InputsOutputs.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddSalesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SellerName = c.String(nullable: false, maxLength: 128),
                        Date = c.DateTime(nullable: false),
                        Name = c.String(nullable: false, maxLength: 1024),
                        PriceRonCash = c.Int(nullable: false),
                        PriceRonCashRegister = c.Int(nullable: false),
                        PriceEuro = c.Int(nullable: false),
                        PricePounds = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sales");
        }
    }
}
