using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class updatedDivines : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Divines_Divines_Divineid",
                table: "Divines");

            migrationBuilder.DropForeignKey(
                name: "FK_Divines_Pantheons_pantheonId",
                table: "Divines");

            migrationBuilder.DropIndex(
                name: "IX_Divines_Divineid",
                table: "Divines");

            migrationBuilder.DropColumn(
                name: "Divineid",
                table: "Divines");

            migrationBuilder.RenameColumn(
                name: "pantheonId",
                table: "Divines",
                newName: "PantheonId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Divines",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Divines",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Divines",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Divines_pantheonId",
                table: "Divines",
                newName: "IX_Divines_PantheonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Divines_Pantheons_PantheonId",
                table: "Divines",
                column: "PantheonId",
                principalTable: "Pantheons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Divines_Pantheons_PantheonId",
                table: "Divines");

            migrationBuilder.RenameColumn(
                name: "PantheonId",
                table: "Divines",
                newName: "pantheonId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Divines",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Divines",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Divines",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Divines_PantheonId",
                table: "Divines",
                newName: "IX_Divines_pantheonId");

            migrationBuilder.AddColumn<int>(
                name: "Divineid",
                table: "Divines",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Divines_Divineid",
                table: "Divines",
                column: "Divineid");

            migrationBuilder.AddForeignKey(
                name: "FK_Divines_Divines_Divineid",
                table: "Divines",
                column: "Divineid",
                principalTable: "Divines",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Divines_Pantheons_pantheonId",
                table: "Divines",
                column: "pantheonId",
                principalTable: "Pantheons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
