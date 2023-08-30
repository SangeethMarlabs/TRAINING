namespace Marlabs_Customer_DatabaseConnectivity_Ex2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustId = c.Int(nullable: false, identity: true),
                        CustName = c.String(),
                        CustEmail = c.String(),
                        CustAddress = c.String(),
                        CustPhone = c.String(),
                    })
                .PrimaryKey(t => t.CustId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
