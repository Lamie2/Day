using Microsoft.EntityFrameworkCore.Migrations;

namespace Day.Migrations
{
    public partial class TeamMembersTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(maxLength: 30, nullable: true),
                    Position = table.Column<string>(maxLength: 30, nullable: true),
                    Desc = table.Column<string>(maxLength: 300, nullable: true),
                    TwitterUrl = table.Column<string>(maxLength: 100, nullable: true),
                    FacebookUrl = table.Column<string>(maxLength: 100, nullable: true),
                    InstaUrl = table.Column<string>(maxLength: 100, nullable: true),
                    LinkednUrl = table.Column<string>(maxLength: 100, nullable: true),
                    Image = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamMembers");
        }
    }
}
