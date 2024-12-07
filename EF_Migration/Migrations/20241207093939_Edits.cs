using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_Migration.Migrations
{
    /// <inheritdoc />
    public partial class Edits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Co");

            migrationBuilder.CreateTable(
                name: "Instructors",
                schema: "Co",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                schema: "Co",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TotalHours = table.Column<int>(type: "int", nullable: false),
                    instructorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Instructors_instructorId",
                        column: x => x.instructorId,
                        principalSchema: "Co",
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Co",
                table: "Instructors",
                columns: new[] { "Id", "Address", "Name", "salary" },
                values: new object[,]
                {
                    { 1, "Bajour", "Mahmoud", 30000m },
                    { 2, "shebin", "Taha", 20000m },
                    { 3, "Menofia", "Issam", 60000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_instructorId",
                schema: "Co",
                table: "Courses",
                column: "instructorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses",
                schema: "Co");

            migrationBuilder.DropTable(
                name: "Instructors",
                schema: "Co");
        }
    }
}
