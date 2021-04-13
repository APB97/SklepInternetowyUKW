namespace Sklep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteFilmLength : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Films", "FilmLength");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Films", "FilmLength", c => c.Int(nullable: false));
        }
    }
}
