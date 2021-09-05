namespace C_ModelsApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoris",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Adi = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Makales",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Baslik = c.String(),
                        Icerik = c.String(),
                        KategoriID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kategoris", t => t.KategoriID, cascadeDelete: true)
                .Index(t => t.KategoriID);
            
            CreateTable(
                "dbo.Yorums",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Tarih = c.DateTime(nullable: false),
                        Nick = c.String(),
                        Icerik = c.String(),
                        MakaleID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Makales", t => t.MakaleID, cascadeDelete: true)
                .Index(t => t.MakaleID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Yorums", "MakaleID", "dbo.Makales");
            DropForeignKey("dbo.Makales", "KategoriID", "dbo.Kategoris");
            DropIndex("dbo.Yorums", new[] { "MakaleID" });
            DropIndex("dbo.Makales", new[] { "KategoriID" });
            DropTable("dbo.Yorums");
            DropTable("dbo.Makales");
            DropTable("dbo.Kategoris");
        }
    }
}
