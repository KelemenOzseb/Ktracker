using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class UserFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Users_UserID",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_BodyFatCircumMen_Users_UserId",
                table: "BodyFatCircumMen");

            migrationBuilder.DropForeignKey(
                name: "FK_BodyFatCircumWomen_Users_UserID",
                table: "BodyFatCircumWomen");

            migrationBuilder.DropForeignKey(
                name: "FK_BodyFatFromSkinfolds_Users_UserId",
                table: "BodyFatFromSkinfolds");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Users_UserID",
                table: "Foods");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDailyStats_Users_UserID",
                table: "UserDailyStats");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFemale",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PreferredBodyFatMethod",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PreferredCalorieMethod",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_AspNetUsers_UserID",
                table: "Activities",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BodyFatCircumMen_AspNetUsers_UserId",
                table: "BodyFatCircumMen",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BodyFatCircumWomen_AspNetUsers_UserID",
                table: "BodyFatCircumWomen",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BodyFatFromSkinfolds_AspNetUsers_UserId",
                table: "BodyFatFromSkinfolds",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_AspNetUsers_UserID",
                table: "Foods",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDailyStats_AspNetUsers_UserID",
                table: "UserDailyStats",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_AspNetUsers_UserID",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_BodyFatCircumMen_AspNetUsers_UserId",
                table: "BodyFatCircumMen");

            migrationBuilder.DropForeignKey(
                name: "FK_BodyFatCircumWomen_AspNetUsers_UserID",
                table: "BodyFatCircumWomen");

            migrationBuilder.DropForeignKey(
                name: "FK_BodyFatFromSkinfolds_AspNetUsers_UserId",
                table: "BodyFatFromSkinfolds");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_AspNetUsers_UserID",
                table: "Foods");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDailyStats_AspNetUsers_UserID",
                table: "UserDailyStats");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsFemale",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PreferredBodyFatMethod",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PreferredCalorieMethod",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    IsFemale = table.Column<bool>(type: "bit", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreferredBodyFatMethod = table.Column<int>(type: "int", nullable: true),
                    PreferredCalorieMethod = table.Column<int>(type: "int", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Users_UserID",
                table: "Activities",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BodyFatCircumMen_Users_UserId",
                table: "BodyFatCircumMen",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BodyFatCircumWomen_Users_UserID",
                table: "BodyFatCircumWomen",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BodyFatFromSkinfolds_Users_UserId",
                table: "BodyFatFromSkinfolds",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Users_UserID",
                table: "Foods",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDailyStats_Users_UserID",
                table: "UserDailyStats",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
