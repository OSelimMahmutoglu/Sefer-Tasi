namespace SeferTasiADO.EntityProject.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SiparisDetay", "Adet", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SiparisDetay", "Adet", c => c.Int());
        }
    }
}
