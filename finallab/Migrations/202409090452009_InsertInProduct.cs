namespace FinalLabCF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertInProduct : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Products values ('MS Word',1,5000)");
            Sql("Insert into Products values ('MS Teams',1,7000)");
            Sql("Insert into Products values ('Mouse',2,5000)");
            Sql("Insert into Products values ('Joystick',2,3000)");
        }
        
        public override void Down()
        {
        }
    }
}
