namespace dataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initnew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.people", "birthDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.personDetails", "value", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.personDetails", "value");
            DropColumn("dbo.people", "birthDate");
        }
    }
}
