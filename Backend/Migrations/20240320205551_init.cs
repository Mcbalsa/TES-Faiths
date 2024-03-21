using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pantheons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pantheons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Divines",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pantheonId = table.Column<int>(type: "int", nullable: false),
                    Divineid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divines", x => x.id);
                    table.ForeignKey(
                        name: "FK_Divines_Divines_Divineid",
                        column: x => x.Divineid,
                        principalTable: "Divines",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Divines_Pantheons_pantheonId",
                        column: x => x.pantheonId,
                        principalTable: "Pantheons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Divines_Divineid",
                table: "Divines",
                column: "Divineid");

            migrationBuilder.CreateIndex(
                name: "IX_Divines_pantheonId",
                table: "Divines",
                column: "pantheonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Divines");

            migrationBuilder.DropTable(
                name: "Pantheons");
        }
    }
}
