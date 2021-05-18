namespace Sklep.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fix_UserData : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "UserData_Name", c => c.String());
            AlterColumn("dbo.AspNetUsers", "UserData_Surname", c => c.String());
            AlterColumn("dbo.AspNetUsers", "UserData_Email", c => c.String());
            AlterColumn("dbo.AspNetUsers", "UserData_PhoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "UserData_PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.AspNetUsers", "UserData_Email", c => c.String(nullable: false));
            AlterColumn("dbo.AspNetUsers", "UserData_Surname", c => c.String(nullable: false));
            AlterColumn("dbo.AspNetUsers", "UserData_Name", c => c.String(nullable: false));
        }
    }
}
