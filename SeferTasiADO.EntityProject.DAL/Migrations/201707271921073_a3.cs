namespace SeferTasiADO.EntityProject.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Siparisler", "TeslimTarihi", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Siparisler", "TeslimTarihi");
        }
    }
}
