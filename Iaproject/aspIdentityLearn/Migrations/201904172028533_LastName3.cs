namespace aspIdentityLearn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LastName3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "JobDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "JobDescription");
        }
    }
}
