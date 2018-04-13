namespace BlueRibbonsReview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CampaignModelUpdateToApplicationUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Campaigns", "SellerID", "dbo.Sellers");
            DropIndex("dbo.Campaigns", new[] { "SellerID" });
            RenameColumn(table: "dbo.Campaigns", name: "SellerID", newName: "Seller_SellerID");
            AddColumn("dbo.Campaigns", "UserID", c => c.String());
            AlterColumn("dbo.Campaigns", "Seller_SellerID", c => c.Guid());
            CreateIndex("dbo.Campaigns", "Seller_SellerID");
            AddForeignKey("dbo.Campaigns", "Seller_SellerID", "dbo.Sellers", "SellerID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Campaigns", "Seller_SellerID", "dbo.Sellers");
            DropIndex("dbo.Campaigns", new[] { "Seller_SellerID" });
            AlterColumn("dbo.Campaigns", "Seller_SellerID", c => c.Guid(nullable: false));
            DropColumn("dbo.Campaigns", "UserID");
            RenameColumn(table: "dbo.Campaigns", name: "Seller_SellerID", newName: "SellerID");
            CreateIndex("dbo.Campaigns", "SellerID");
            AddForeignKey("dbo.Campaigns", "SellerID", "dbo.Sellers", "SellerID", cascadeDelete: true);
        }
    }
}
