using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lanes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleName = table.Column<string>(nullable: true),
                    RoleDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lanes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Champions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Rank = table.Column<string>(nullable: true),
                    LaneId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Champions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Champions_Lanes_LaneId",
                        column: x => x.LaneId,
                        principalTable: "Lanes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Champions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Lanes",
                columns: new[] { "Id", "RoleDescription", "RoleName" },
                values: new object[] { 1, " ", "Mid" });

            migrationBuilder.InsertData(
                table: "Lanes",
                columns: new[] { "Id", "RoleDescription", "RoleName" },
                values: new object[] { 2, " ", "Top" });

            migrationBuilder.InsertData(
                table: "Lanes",
                columns: new[] { "Id", "RoleDescription", "RoleName" },
                values: new object[] { 3, " ", "Jungle" });

            migrationBuilder.InsertData(
                table: "Lanes",
                columns: new[] { "Id", "RoleDescription", "RoleName" },
                values: new object[] { 4, " ", "Adc" });

            migrationBuilder.InsertData(
                table: "Lanes",
                columns: new[] { "Id", "RoleDescription", "RoleName" },
                values: new object[] { 5, " ", "Support" });

            migrationBuilder.CreateIndex(
                name: "IX_Champions_LaneId",
                table: "Champions",
                column: "LaneId");

            migrationBuilder.CreateIndex(
                name: "IX_Champions_UserId",
                table: "Champions",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Champions");

            migrationBuilder.DropTable(
                name: "Lanes");
        }
    }
}
