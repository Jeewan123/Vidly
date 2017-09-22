namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeInCustomerModel : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Customers", name: "MembershipTypeId_Id", newName: "MembershipType_Id");
            RenameIndex(table: "dbo.Customers", name: "IX_MembershipTypeId_Id", newName: "IX_MembershipType_Id");
            AddColumn("dbo.Customers", "MembershipTypeId", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "MembershipTypeId");
            RenameIndex(table: "dbo.Customers", name: "IX_MembershipType_Id", newName: "IX_MembershipTypeId_Id");
            RenameColumn(table: "dbo.Customers", name: "MembershipType_Id", newName: "MembershipTypeId_Id");
        }
    }
}
