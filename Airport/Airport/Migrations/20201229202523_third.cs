using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Airport.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Schedule_1_ScheduleID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Schedule_2_ScheduleOutID",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ScheduleOutID",
                table: "Orders",
                newName: "CityStartScheduleOutID");

            migrationBuilder.RenameColumn(
                name: "ScheduleID",
                table: "Orders",
                newName: "CityFinishScheduleID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ScheduleOutID",
                table: "Orders",
                newName: "IX_Orders_CityStartScheduleOutID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ScheduleID",
                table: "Orders",
                newName: "IX_Orders_CityFinishScheduleID");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Schedule_1_CityFinishScheduleID",
                table: "Orders",
                column: "CityFinishScheduleID",
                principalTable: "Schedule_1",
                principalColumn: "ScheduleID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Schedule_2_CityStartScheduleOutID",
                table: "Orders",
                column: "CityStartScheduleOutID",
                principalTable: "Schedule_2",
                principalColumn: "ScheduleOutID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Schedule_1_CityFinishScheduleID",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Schedule_2_CityStartScheduleOutID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "CityStartScheduleOutID",
                table: "Orders",
                newName: "ScheduleOutID");

            migrationBuilder.RenameColumn(
                name: "CityFinishScheduleID",
                table: "Orders",
                newName: "ScheduleID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CityStartScheduleOutID",
                table: "Orders",
                newName: "IX_Orders_ScheduleOutID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CityFinishScheduleID",
                table: "Orders",
                newName: "IX_Orders_ScheduleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Schedule_1_ScheduleID",
                table: "Orders",
                column: "ScheduleID",
                principalTable: "Schedule_1",
                principalColumn: "ScheduleID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Schedule_2_ScheduleOutID",
                table: "Orders",
                column: "ScheduleOutID",
                principalTable: "Schedule_2",
                principalColumn: "ScheduleOutID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
