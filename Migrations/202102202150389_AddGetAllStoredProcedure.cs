namespace InputsOutputs.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGetAllStoredProcedure : DbMigration
    {
        public override void Up()
        {
            Sql(@"DROP PROCEDURE IF EXISTS [dbo].[GetAll]
GO

CREATE PROCEDURE [dbo].[GetAll] 
	@searchTerm NVARCHAR(MAX),
	@from DATETIME,
	@to DATETIME
AS
BEGIN
	SET NOCOUNT ON;

    DECLARE @sqlQuery NVARCHAR(MAX) = ''
    DECLARE @paramDefinition AS NVARCHAR(MAX)
                  
    SET @sqlQuery = 'SELECT 
						d.Id, 
						d.SellerName, 
						d.Date,
						d.Name,
						d.PriceRonCash,
						d.PriceRonCashRegister,
						d.PriceEuro,
						d.PricePounds,
						d.Type
					 FROM [dbo].[Data] d 
					 WHERE (d.Date BETWEEN @from AND @to) '
                  
    IF (@searchTerm IS NOT NULL AND @searchTerm <> '')
    BEGIN
		SET @sqlQuery = @sqlQuery + 'AND ' + @searchTerm
    END

	SET @paramDefinition = ' @from DATETIME,
                             @to DATETIME'
                  
    EXECUTE sp_Executesql @sqlQuery,
                          @paramDefinition,
                          @from,
                          @to
END");
        }
        
        public override void Down()
        {
        }
    }
}
