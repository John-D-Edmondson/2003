using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _2003.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Evaluator",
            //    columns: table => new
            //    {
            //        evaluatorID = table.Column<int>(type: "int", nullable: false),
            //        evaluatorname = table.Column<string>(name: "evaluator_name", type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__Evaluato__B05254E9143CD590", x => x.evaluatorID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "img",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        picture = table.Column<byte[]>(type: "image", nullable: true),
            //        evaluatorID = table.Column<int>(type: "int", nullable: true),
            //        childage = table.Column<int>(name: "child_age", type: "int", nullable: true),
            //        imgdate = table.Column<DateTime>(name: "img_date", type: "date", nullable: true),
            //        imgevent = table.Column<string>(name: "img_event", type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
            //        depth = table.Column<int>(type: "int", nullable: true),
            //        breadth = table.Column<int>(type: "int", nullable: true),
            //        extent = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK__img__3213E83FA8C7B3CA", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_PersonOrder",
            //            column: x => x.evaluatorID,
            //            principalTable: "Evaluator",
            //            principalColumn: "evaluatorID");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_img_evaluatorID",
            //    table: "img",
            //    column: "evaluatorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "img");

            migrationBuilder.DropTable(
                name: "Evaluator");
        }
    }
}
