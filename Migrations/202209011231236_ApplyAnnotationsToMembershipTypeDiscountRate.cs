namespace TestVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToMembershipTypeDiscountRate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.MembershipTypes", "DiscountRate", c => c.Byte());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MembershipTypes", "DiscountRate", c => c.Byte(nullable: false));
        }
    }
}
