using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2003.Migrations
{
    /// <inheritdoc />
    public partial class AddImgGraded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ImgGraded",
                table: "img",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgGraded",
                table: "img");
        }
    }
}
