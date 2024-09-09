namespace FinalLabCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertInCategory : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Categories values ('Software')");
            Sql("Insert into Categories values ('Hardware')");
        }
        
        public override void Down()
        {
        }
    }
}
