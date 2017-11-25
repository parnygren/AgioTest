namespace AgioTest.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateEmployeeTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Employees (FirstName, LastName) VALUES ('Robert', 'Martin')");
            Sql("INSERT INTO Employees (FirstName, LastName) VALUES ('Sandro', 'Mancuso')");
            Sql("INSERT INTO Employees (FirstName, LastName) VALUES ('Julie', 'Lerman')");
            Sql("INSERT INTO Employees (FirstName, LastName) VALUES ('Scott', 'Allen')");
            Sql("INSERT INTO Employees (FirstName, LastName) VALUES ('Troy', 'Hunt')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Employees WHERE Id IN (1, 2, 3, 4, 5)");
        }
    }
}
