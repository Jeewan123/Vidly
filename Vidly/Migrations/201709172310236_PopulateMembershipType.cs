using System.IO;
using System.Web.UI.WebControls;

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(SignUpFee,Duration,DiscountRate,MembershipName) VALUES (0,0,0,'PayAsYouGo')");
            Sql("INSERT INTO MembershipTypes(SignUpFee,Duration,DiscountRate,MembershipName) VALUES (30,1,10,'Monthly')");



        }
        
        public override void Down()
        {
        }
    }
}
