namespace InputsOutputs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangePriceColumnsType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Costs", "PriceRon", c => c.Int());
            AlterColumn("dbo.Costs", "PriceEuro", c => c.Int());
            AlterColumn("dbo.Costs", "PricePounds", c => c.Int());
            AlterColumn("dbo.Returns", "PriceRon", c => c.Int());
            AlterColumn("dbo.Returns", "PriceEuro", c => c.Int());
            AlterColumn("dbo.Returns", "PricePounds", c => c.Int());
            AlterColumn("dbo.Sales", "PriceRonCash", c => c.Int());
            AlterColumn("dbo.Sales", "PriceRonCashRegister", c => c.Int());
            AlterColumn("dbo.Sales", "PriceEuro", c => c.Int());
            AlterColumn("dbo.Sales", "PricePounds", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Sales", "PricePounds", c => c.Int(nullable: false));
            AlterColumn("dbo.Sales", "PriceEuro", c => c.Int(nullable: false));
            AlterColumn("dbo.Sales", "PriceRonCashRegister", c => c.Int(nullable: false));
            AlterColumn("dbo.Sales", "PriceRonCash", c => c.Int(nullable: false));
            AlterColumn("dbo.Returns", "PricePounds", c => c.Int(nullable: false));
            AlterColumn("dbo.Returns", "PriceEuro", c => c.Int(nullable: false));
            AlterColumn("dbo.Returns", "PriceRon", c => c.Int(nullable: false));
            AlterColumn("dbo.Costs", "PricePounds", c => c.Int(nullable: false));
            AlterColumn("dbo.Costs", "PriceEuro", c => c.Int(nullable: false));
            AlterColumn("dbo.Costs", "PriceRon", c => c.Int(nullable: false));
        }
    }
}
