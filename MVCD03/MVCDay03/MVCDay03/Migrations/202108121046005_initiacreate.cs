namespace MVCDay03.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initiacreate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Departments", "Name", c => c.Int(nullable: false));
        }
    }
}
