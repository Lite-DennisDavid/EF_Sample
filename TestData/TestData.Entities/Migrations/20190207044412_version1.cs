using Microsoft.EntityFrameworkCore.Migrations;

namespace TestData.Entities.Migrations
{
    public partial class version1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TestMeasMeasurementParameterId",
                table: "TestDatas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TestDatas_TestMeasMeasurementParameterId",
                table: "TestDatas",
                column: "TestMeasMeasurementParameterId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestDatas_MeasTable_TestMeasMeasurementParameterId",
                table: "TestDatas",
                column: "TestMeasMeasurementParameterId",
                principalTable: "MeasTable",
                principalColumn: "MeasurementParameterId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestDatas_MeasTable_TestMeasMeasurementParameterId",
                table: "TestDatas");

            migrationBuilder.DropIndex(
                name: "IX_TestDatas_TestMeasMeasurementParameterId",
                table: "TestDatas");

            migrationBuilder.DropColumn(
                name: "TestMeasMeasurementParameterId",
                table: "TestDatas");
        }
    }
}
