namespace PLE444.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hidden : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Chapters", "IsHidden", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Chapters", "IsHidden");
        }
    }
}
