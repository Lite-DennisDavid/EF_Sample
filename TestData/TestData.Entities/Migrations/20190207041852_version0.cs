using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestData.Entities.Migrations
{
    public partial class version0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeasTable",
                columns: table => new
                {
                    MeasurementParameterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true),
                    Units = table.Column<string>(nullable: true),
                    Pass = table.Column<string>(nullable: true),
                    Min = table.Column<double>(nullable: false),
                    Max = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasTable", x => x.MeasurementParameterId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeasTable");
        }
    }
}
