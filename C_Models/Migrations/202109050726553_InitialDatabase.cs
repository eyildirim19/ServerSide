namespace C_Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Uruns",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                        Fiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EskiFiyat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImagePath = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Uruns");
        }
    }
}
