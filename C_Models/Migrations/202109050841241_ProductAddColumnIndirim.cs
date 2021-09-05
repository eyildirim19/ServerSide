namespace C_Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductAddColumnIndirim : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Uruns", "IndirimVar", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Uruns", "IndirimVar");
        }
    }
}
