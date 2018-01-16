namespace WpfApp1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Artis", "Name", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Artis", "LastName", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Artis", "Age", c => c.Int(nullable: false));
            DropColumn("dbo.Artis", "Title");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Artis", "Title", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Artis", "Age");
            DropColumn("dbo.Artis", "LastName");
            DropColumn("dbo.Artis", "Name");
        }
    }
}
