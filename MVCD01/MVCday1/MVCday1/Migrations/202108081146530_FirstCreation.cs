namespace MVCday1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Age = c.Int(nullable: false),
                        Name = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
