using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestData.Entities.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestDatas",
                columns: table => new
                {
                    TestDataId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SerialNumber = table.Column<string>(nullable: true),
                    CustomerSerialNumber = table.Column<string>(nullable: true),
                    BatchNumber = table.Column<string>(nullable: true),
                    PartNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestDatas", x => x.TestDataId);
                });

            migrationBuilder.InsertData(
                table: "TestDatas",
                columns: new[] { "TestDataId", "BatchNumber", "CustomerSerialNumber", "PartNumber", "SerialNumber" },
                values: new object[] { 1, "J123", "Cisco12345", "64000236", "NJ123456789" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestDatas");
        }
    }
}
