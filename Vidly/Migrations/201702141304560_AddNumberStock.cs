namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberStock : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberInStock", c => c.Short(nullable: false));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 245));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Name", c => c.String());
            DropColumn("dbo.Movies", "NumberInStock");
        }
    }
}
