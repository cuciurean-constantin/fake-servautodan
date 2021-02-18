namespace InputsOutputs.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddAllView : DbMigration
    {
        public override void Up()
        {
            Sql(@"DROP VIEW IF EXISTS [dbo].[All]
                  GO
                  
                  CREATE VIEW [dbo].[All]
                  AS
                  SELECT        Id, SellerName, Date, Name, PriceRonCash, PriceRonCashRegister, PriceEuro, PricePounds, 'Sale' AS Type
                  FROM            dbo.Sales
                  UNION ALL
                  SELECT        Id, NULL as SellerName, Date, Name, PriceRon AS PriceRonCash, NULL as PriceRonCashRegister, PriceEuro, PricePounds, 'Cost' AS Type
                  FROM            dbo.Costs
                  UNION ALL
                  SELECT        Id, NULL as SellerName, Date, Name, PriceRon AS PriceRonCash, NULL as PriceRonCashRegister, PriceEuro, PricePounds, 'Return' AS Type
                  FROM            dbo.Returns");
        }
        
        public override void Down()
        {
        }
    }
}
