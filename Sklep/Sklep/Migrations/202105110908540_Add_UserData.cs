namespace Sklep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_UserData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "UserData_Name", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "UserData_Surname", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "UserData_Email", c => c.String(nullable: false));
            AddColumn("dbo.AspNetUsers", "UserData_PhoneNumber", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "UserData_PhoneNumber");
            DropColumn("dbo.AspNetUsers", "UserData_Email");
            DropColumn("dbo.AspNetUsers", "UserData_Surname");
            DropColumn("dbo.AspNetUsers", "UserData_Name");
        }
    }
}
