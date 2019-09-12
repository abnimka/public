namespace Applic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tkans", "Risunok");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tkans", "Risunok", c => c.String());
        }
    }
}
