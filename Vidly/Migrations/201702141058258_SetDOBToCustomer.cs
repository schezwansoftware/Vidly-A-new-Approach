namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetDOBToCustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "DateOfBirth", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "DateOfBirth", c => c.DateTime());
        }
    }
}
