using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class _addd_new_fields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserIDFriend",
                table: "FriendLists");

            migrationBuilder.DropColumn(
                name: "UserIDMy",
                table: "FriendLists");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Relationship",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserIDFriendID",
                table: "FriendLists",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserIDMyID",
                table: "FriendLists",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FriendLists_UserIDFriendID",
                table: "FriendLists",
                column: "UserIDFriendID");

            migrationBuilder.CreateIndex(
                name: "IX_FriendLists_UserIDMyID",
                table: "FriendLists",
                column: "UserIDMyID");

            migrationBuilder.AddForeignKey(
                name: "FK_FriendLists_Users_UserIDFriendID",
                table: "FriendLists",
                column: "UserIDFriendID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FriendLists_Users_UserIDMyID",
                table: "FriendLists",
                column: "UserIDMyID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FriendLists_Users_UserIDFriendID",
                table: "FriendLists");

            migrationBuilder.DropForeignKey(
                name: "FK_FriendLists_Users_UserIDMyID",
                table: "FriendLists");

            migrationBuilder.DropIndex(
                name: "IX_FriendLists_UserIDFriendID",
                table: "FriendLists");

            migrationBuilder.DropIndex(
                name: "IX_FriendLists_UserIDMyID",
                table: "FriendLists");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Relationship",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserIDFriendID",
                table: "FriendLists");

            migrationBuilder.DropColumn(
                name: "UserIDMyID",
                table: "FriendLists");

            migrationBuilder.AddColumn<int>(
                name: "UserIDFriend",
                table: "FriendLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserIDMy",
                table: "FriendLists",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
