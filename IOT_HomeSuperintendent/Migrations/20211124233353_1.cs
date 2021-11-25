using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IOT_HomeSuperintendent.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Datas",
                columns: table => new
                {
                    IDData = table.Column<string>(type: "varchar(767)", nullable: false),
                    IDDevice = table.Column<string>(type: "text", nullable: false),
                    value = table.Column<string>(type: "text", nullable: false),
                    DataType = table.Column<string>(type: "text", nullable: false),
                    TimeStamp = table.Column<long>(type: "bigint", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datas", x => x.IDData);
                });

            migrationBuilder.UpdateData(
                table: "IOTDevice",
                keyColumn: "IDDevice",
                keyValue: "38B9F907-5961-4589-90E8-9EC020B7D40D",
                columns: new[] { "DeviceName", "DeviceType" },
                values: new object[] { "Sensor Nivel de Agua", "water_level_sensor" });

            migrationBuilder.UpdateData(
                table: "IOTDevice",
                keyColumn: "IDDevice",
                keyValue: "74F61449-AFA3-4D38-BBDE-4CE2600732D6",
                columns: new[] { "DeviceName", "DeviceType" },
                values: new object[] { "Sensor Nivel de Agua", "water_level_sensor" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Datas");

            migrationBuilder.UpdateData(
                table: "IOTDevice",
                keyColumn: "IDDevice",
                keyValue: "38B9F907-5961-4589-90E8-9EC020B7D40D",
                columns: new[] { "DeviceName", "DeviceType" },
                values: new object[] { "Water Level Sensor", "Water Level Sensor" });

            migrationBuilder.UpdateData(
                table: "IOTDevice",
                keyColumn: "IDDevice",
                keyValue: "74F61449-AFA3-4D38-BBDE-4CE2600732D6",
                columns: new[] { "DeviceName", "DeviceType" },
                values: new object[] { "Water Level Sensor", "Water Level Sensor" });
        }
    }
}
