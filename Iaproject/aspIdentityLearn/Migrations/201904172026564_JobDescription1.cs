namespace aspIdentityLearn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JobDescription1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "JobDescription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "JobDescription", c => c.String());
        }
    }
}
