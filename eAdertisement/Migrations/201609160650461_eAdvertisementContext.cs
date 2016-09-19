namespace eAdertisement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eAdvertisementContext : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vacancy", "Requirements", c => c.String());
            AlterColumn("dbo.Vacancy", "Post", c => c.String(unicode: false));
            AlterColumn("dbo.Vacancy", "Attention", c => c.String(unicode: false));
            AlterColumn("dbo.Vacancy", "Salary", c => c.String(unicode: false));
            AlterColumn("dbo.Vacancy", "Centre", c => c.String(unicode: false));
            AlterColumn("dbo.Vacancy", "Application", c => c.String(unicode: false));
            AlterColumn("dbo.Vacancy", "Note", c => c.String(unicode: false));
            AlterColumn("dbo.Vacancy", "Duties", c => c.String(unicode: false));
            AlterColumn("dbo.Vacancy", "ReferenceNo", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vacancy", "ReferenceNo", c => c.String(maxLength: 200, unicode: false));
            AlterColumn("dbo.Vacancy", "Duties", c => c.String(maxLength: 200, unicode: false));
            AlterColumn("dbo.Vacancy", "Note", c => c.String(maxLength: 200, unicode: false));
            AlterColumn("dbo.Vacancy", "Application", c => c.String(maxLength: 200, unicode: false));
            AlterColumn("dbo.Vacancy", "Centre", c => c.String(maxLength: 200, unicode: false));
            AlterColumn("dbo.Vacancy", "Salary", c => c.String(maxLength: 500, unicode: false));
            AlterColumn("dbo.Vacancy", "Attention", c => c.String(maxLength: 200, unicode: false));
            AlterColumn("dbo.Vacancy", "Post", c => c.String(maxLength: 200, unicode: false));
            DropColumn("dbo.Vacancy", "Requirements");
        }
    }
}
