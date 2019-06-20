namespace PharmaFactory.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DepositModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deposits",
                c => new
                    {
                        IdDeposit = c.Int(nullable: false, identity: true),
                        Location = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.IdDeposit);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Deposits");
        }
    }
}
