namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedResourceProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Note", "Resource", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Note", "Resource");
        }
    }
}
