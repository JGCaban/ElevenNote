namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addContactProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Note", "Contact", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Note", "Contact");
        }
    }
}
