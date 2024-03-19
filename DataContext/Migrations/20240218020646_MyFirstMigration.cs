using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace my_app.DataContext.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Persons",
                schema: "dbo",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonId);
                });

            // var path = Environment.CurrentDirectory;
            // string sql = File.ReadAllText(Path.Combine(path, "DataContext\\Scripts\\spsIEM_MigrationTest_v8.sql"));
            // migrationBuilder.Sql(sql);
            //create .sql file in script folder
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons",
                schema: "dbo");
        }
    }
}
