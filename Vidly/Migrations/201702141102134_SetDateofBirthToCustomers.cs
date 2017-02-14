namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetDateofBirthToCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET DateOfBirth=CAST('18/08/1998' AS DateTime) WHERE Id=2" );
            Sql("UPDATE Customers SET DateOfBirth=CAST('18/08/1998' AS DateTime) WHERE Id=5");

        }

        public override void Down()
        {
        }
    }
}
