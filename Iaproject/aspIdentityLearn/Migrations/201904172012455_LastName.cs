namespace aspIdentityLearn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LastName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "JobDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "JobDescription");
            DropColumn("dbo.AspNetUsers", "LastName");
        }
    }
}
