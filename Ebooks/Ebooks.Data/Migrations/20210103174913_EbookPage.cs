using Microsoft.EntityFrameworkCore.Migrations;

namespace Ebooks.Data.Migrations
{
    public partial class EbookPage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageNo = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EbookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pages_Ebooks_EbookId",
                        column: x => x.EbookId,
                        principalTable: "Ebooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Content", "EbookId", "PageNo" },
                values: new object[] { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aenean faucibus condimentum est ut vehicula. Fusce ornare, purus nec auctor malesuada, enim est porttitor justo, sed eleifend orci urna sed enim. Mauris volutpat enim sem, at aliquam libero interdum eget. Donec luctus nisl a mollis placerat. Nam scelerisque magna vel leo auctor, a dapibus ipsum eleifend. Nunc sodales bibendum consequat. Vivamus efficitur risus ac lacus elementum, sit amet condimentum tellus aliquet. In et mi ac nunc bibendum tincidunt sed a orci. Donec vel tortor et magna luctus laoreet ut et urna. Aliquam eu nulla efficitur, cursus enim gravida, rutrum diam. Morbi feugiat neque ac convallis auctor. Suspendisse magna arcu, rhoncus id dolor in, ullamcorper hendrerit velit. Curabitur tincidunt dui eget commodo elementum. Sed eu eleifend mauris. Donec non nisi eros.Aliquam erat arcu, tincidunt sodales tortor vel, lobortis fringilla nibh. Etiam eu tortor et magna ultricies suscipit. Cras scelerisque lorem nec nisl accumsan, in sagittis orci viverra. Ut sit amet urna urna. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin interdum augue at sapien viverra, sed cursus mauris dignissim. Aliquam erat volutpat. Aliquam sed massa sem. Donec id tempor odio, non hendrerit eros. Donec imperdiet eros non dignissim ornare. Aliquam vitae semper metus. Nunc eget dui nulla. Nulla facilisi.", 1, 1 });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Content", "EbookId", "PageNo" },
                values: new object[] { 2, "Phasellus luctus interdum massa at auctor. Praesent fermentum ipsum sit amet pulvinar tristique. Nullam venenatis et neque vitae iaculis. Donec ligula ex, vestibulum laoreet ipsum ut, consectetur cursus ex. Quisque molestie vulputate purus, in luctus nisi. Aliquam consequat, nulla quis tincidunt elementum, nunc felis convallis quam, in consectetur lacus elit ac dui. Quisque posuere tortor sed convallis rutrum. Nunc congue risus et ipsum convallis interdum. Sed ac bibendum nisl. Vestibulum molestie ut odio vel suscipit. Sed semper ac lacus in mollis. Ut non lacus arcu.", 1, 2 });

            migrationBuilder.InsertData(
                table: "Pages",
                columns: new[] { "Id", "Content", "EbookId", "PageNo" },
                values: new object[] { 3, "Sed scelerisque scelerisque consequat. Curabitur placerat faucibus sem a luctus. Pellentesque malesuada aliquam scelerisque. Cras blandit ullamcorper est, eget tempus quam consectetur non. Suspendisse maximus gravida velit, eget ultricies nulla egestas vel. Mauris non scelerisque nibh. Sed dictum augue nibh, vitae mollis felis pharetra ac. Nam efficitur libero id urna commodo, sed bibendum lacus vulputate. Duis vitae dui laoreet, tincidunt turpis sed, bibendum erat. Donec rhoncus eget erat id viverra. Pellentesque dolor justo, faucibus ut lorem vitae, pulvinar varius libero. Nulla bibendum egestas lorem, ut lacinia diam tincidunt a. Vivamus eu justo at tellus tempus hendrerit id suscipit mi. Duis porttitor mauris et faucibus tempus.", 2, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Pages_EbookId",
                table: "Pages",
                column: "EbookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pages");
        }
    }
}
