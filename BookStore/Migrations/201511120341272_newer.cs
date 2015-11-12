namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "EmailAdress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "EmailAdress");
        }
    }
}
