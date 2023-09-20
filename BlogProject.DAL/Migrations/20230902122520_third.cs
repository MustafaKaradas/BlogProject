using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogProject.DAL.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "370c81d7-8e7f-4d4c-88db-65e76f196d6e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d7eae446-7e24-4403-b165-47457c24b3e8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c0f2b21-c4b7-4214-911c-62801a342a60", "AQAAAAEAACcQAAAAEMlwwNhkMLSOhQFsHy8hlleSsH79Nt+qYZQrnp1vl8VWb3WrcmxT3jA+aUq/eGxcHw==", "d5d9009b-35e5-4beb-bee2-e9b82b05c647" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04e55fd2-8699-455b-a5ab-a63bf1894982", "AQAAAAEAACcQAAAAEMlwwNhkMLSOhQFsHy8hlleSsH79Nt+qYZQrnp1vl8VWb3WrcmxT3jA+aUq/eGxcHw==", "f9825e33-0359-467d-870d-72d8186568e6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "01830378-a6df-4a93-a412-c119f6da7291");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "de460cb4-c186-4a56-aada-aac8fa71cc99");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3451f778-7ec1-4690-9be7-e3eea5d09856", null, null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90c79fb8-cc37-45d6-9aa1-35b60e2049e7", null, null });
        }
    }
}
