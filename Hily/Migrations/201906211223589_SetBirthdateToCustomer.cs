namespace Hily.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetBirthdateToCustomer : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET BirthDate = '1980/1/1' WHERE Id = 1");
            Sql("UPDATE Customers SET BirthDate  = '1999/2/2' WHERE Id = 2");
        }

        public override void Down()
        {

        }
    }
}
