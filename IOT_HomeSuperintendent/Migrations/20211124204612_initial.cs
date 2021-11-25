using Microsoft.EntityFrameworkCore.Migrations;

namespace IOT_HomeSuperintendent.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IOTDevice",
                columns: table => new
                {
                    IDDevice = table.Column<string>(type: "varchar(767)", nullable: false),
                    MacAddress = table.Column<string>(type: "varchar(767)", nullable: false),
                    IPAddress = table.Column<string>(type: "text", nullable: false),
                    DeviceType = table.Column<string>(type: "text", nullable: false),
                    DeviceName = table.Column<string>(type: "text", nullable: false),
                    DataType = table.Column<string>(type: "text", nullable: false),
                    MeasurementUnit = table.Column<string>(type: "text", nullable: false),
                    FirmwareVersion = table.Column<string>(type: "text", nullable: false),
                    DeviceStatus = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IOTDevice", x => x.IDDevice);
                });

            migrationBuilder.InsertData(
                table: "IOTDevice",
                columns: new[] { "IDDevice", "DataType", "DeviceName", "DeviceStatus", "DeviceType", "FirmwareVersion", "IPAddress", "MacAddress", "MeasurementUnit" },
                values: new object[] { "38B9F907-5961-4589-90E8-9EC020B7D40D", "float", "Water Level Sensor", "Online", "Water Level Sensor", "1.0.1", "192.168.31.99", "47-1D-44-CB-BF-05", "%" });

            migrationBuilder.InsertData(
                table: "IOTDevice",
                columns: new[] { "IDDevice", "DataType", "DeviceName", "DeviceStatus", "DeviceType", "FirmwareVersion", "IPAddress", "MacAddress", "MeasurementUnit" },
                values: new object[] { "74F61449-AFA3-4D38-BBDE-4CE2600732D6", "float", "Water Level Sensor", "Online", "Water Level Sensor", "1.0.1", "192.168.31.100", "01-2F-7A-93-A3-46", "%" });

            migrationBuilder.CreateIndex(
                name: "IX_IOTDevice_MacAddress",
                table: "IOTDevice",
                column: "MacAddress",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IOTDevice");
        }
    }
}
