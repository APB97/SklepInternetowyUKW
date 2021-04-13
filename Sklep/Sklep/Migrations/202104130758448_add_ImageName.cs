namespace Sklep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_ImageName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "ImageName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "ImageName");
        }
    }
}
