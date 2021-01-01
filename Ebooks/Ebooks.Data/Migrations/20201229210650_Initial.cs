using Microsoft.EntityFrameworkCore.Migrations;

namespace Ebooks.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ebooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ebooks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Ebooks",
                columns: new[] { "Id", "Author", "Description", "Name" },
                values: new object[] { 1, "Peter Himschoot", "Build web applications in C# and Microsoft .NET that run in any modern browser. This second edition is updated to work with the release version of Blazor and covers Blazor’s use in creating both server-side and WebAssembly Blazor applications", "Microsoft Blazor: Building Web Applications in .NET" });

            migrationBuilder.InsertData(
                table: "Ebooks",
                columns: new[] { "Id", "Author", "Description", "Name" },
                values: new object[] { 2, "Michele Aponte", "Attention .NET developers who no longer want to use JavaScript for your front end. Quickly and efficiently learn how to use C# for your single-page application (SPA) thanks to Blazor", "Building Single Page Applications in .NET Core 3: Jumpstart Coding Using Blazor and C#" });

            migrationBuilder.InsertData(
                table: "Ebooks",
                columns: new[] { "Id", "Author", "Description", "Name" },
                values: new object[] { 3, "Adam Freeman", "Now in its 8th edition, Pro ASP.NET Core has been thoroughly updated for ASP.NET Core 3 and online for ASP.NET Core 5 and .NET 5.0. This comprehensive, full-color guide is the only book you need to learn ASP.NET Core development.", "Pro ASP.NET Core 3: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ebooks");
        }
    }
}
