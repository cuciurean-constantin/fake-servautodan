namespace InputsOutputs.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddReturnsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Returns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Name = c.String(nullable: false, maxLength: 1024),
                        PriceRon = c.Int(nullable: false),
                        PriceEuro = c.Int(nullable: false),
                        PricePounds = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            RenameColumn("dbo.Costs", "PriceRonCash", "PriceRon");
        }
        
        public override void Down()
        {
            RenameColumn("dbo.Costs", "PriceRon", "PriceRonCash");
            DropTable("dbo.Returns");
        }
    }
}
