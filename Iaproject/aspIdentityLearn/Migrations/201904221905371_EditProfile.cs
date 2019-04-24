namespace aspIdentityLearn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditProfile : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EditProfiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        PhoneNumber = c.String(),
                        JobDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EditProfiles");
        }
    }
}
