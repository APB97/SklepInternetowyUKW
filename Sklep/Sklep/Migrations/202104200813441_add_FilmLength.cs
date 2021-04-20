namespace Sklep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_FilmLength : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "FilmLength", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Films", "FilmLength");
        }
    }
}
