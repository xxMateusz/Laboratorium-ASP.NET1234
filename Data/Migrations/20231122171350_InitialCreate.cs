using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "40358116-35e4-41f0-9e78-e31cf01c3f8e", "76ac3c01-4d87-4e27-90bd-95121a486672" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "54f2034f-b5e7-4550-9232-5797c26f640d", "8fedb26e-1551-41f7-8750-780f01bbf43e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40358116-35e4-41f0-9e78-e31cf01c3f8e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54f2034f-b5e7-4550-9232-5797c26f640d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76ac3c01-4d87-4e27-90bd-95121a486672");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fedb26e-1551-41f7-8750-780f01bbf43e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01e02449-d2bc-4136-9c96-57513dfc0563", "01e02449-d2bc-4136-9c96-57513dfc0563", "user", "USER" },
                    { "e55eb4ee-8b7f-49f6-adfa-bee1e639f95e", "e55eb4ee-8b7f-49f6-adfa-bee1e639f95e", "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "55d7a1c3-5cfc-4473-ac0d-c4d3f9406af3", 0, "503af430-3498-4f65-83dd-054de259dd5d", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU>PL", "ADAM", "AQAAAAEAACcQAAAAEBB5qErdcrHP6LPEn92J3jDEMrWHBc18DdJjegnHKlmRKVsqdEE0Cy483pqPqCLTGg==", null, false, "2cc5d987-45f9-4b80-843b-9f1f0124fbc9", false, "adam" },
                    { "81a306f1-65d5-4b19-a5b9-ba6a4bd162d9", 0, "48f71b7d-b654-4ca2-b926-e86c200d46d3", "marcin@wsei.edu.pl", true, false, null, "MARCIN@WSEI.EDU>PL", "MARCIN", "AQAAAAEAACcQAAAAEDWoy0JAo6KIZ03gjNn+PDdMgjWAN9c4KpCbbnFCO1pGIZwg8GwHarI5M9s698xBjg==", null, false, "f703e027-3803-40bb-84b9-6940df1efcd1", false, "marcin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e55eb4ee-8b7f-49f6-adfa-bee1e639f95e", "55d7a1c3-5cfc-4473-ac0d-c4d3f9406af3" },
                    { "01e02449-d2bc-4136-9c96-57513dfc0563", "81a306f1-65d5-4b19-a5b9-ba6a4bd162d9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e55eb4ee-8b7f-49f6-adfa-bee1e639f95e", "55d7a1c3-5cfc-4473-ac0d-c4d3f9406af3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "01e02449-d2bc-4136-9c96-57513dfc0563", "81a306f1-65d5-4b19-a5b9-ba6a4bd162d9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01e02449-d2bc-4136-9c96-57513dfc0563");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e55eb4ee-8b7f-49f6-adfa-bee1e639f95e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55d7a1c3-5cfc-4473-ac0d-c4d3f9406af3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81a306f1-65d5-4b19-a5b9-ba6a4bd162d9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40358116-35e4-41f0-9e78-e31cf01c3f8e", "40358116-35e4-41f0-9e78-e31cf01c3f8e", "admin", "ADMIN" },
                    { "54f2034f-b5e7-4550-9232-5797c26f640d", "54f2034f-b5e7-4550-9232-5797c26f640d", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "76ac3c01-4d87-4e27-90bd-95121a486672", 0, "55135d5b-4ed4-4531-85bd-4c4aef009875", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU>PL", null, "AQAAAAEAACcQAAAAECKqgeDZRlcA4C+H8bf4mySadG6XjiezGP6ZR6yRV0tUfLo+KhUJebWWYb9qPLgf7A==", null, false, "91076cd8-925a-44a0-80ac-5674daad1431", false, "adam" },
                    { "8fedb26e-1551-41f7-8750-780f01bbf43e", 0, "fe412491-51f4-49b1-8beb-ca136ee35b1c", "marcin@wsei.edu.pl", true, false, null, "MARCIN@WSEI.EDU>PL", null, "AQAAAAEAACcQAAAAECGQRmzzvBBGr+qe0LhPpjTeltfGPL2DKRspVCy5WaGN8fbuAS6nIR1MLrns3h/4hw==", null, false, "df2e0f64-2b65-4b9c-ad22-f247139d89d3", false, "marcin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "40358116-35e4-41f0-9e78-e31cf01c3f8e", "76ac3c01-4d87-4e27-90bd-95121a486672" },
                    { "54f2034f-b5e7-4550-9232-5797c26f640d", "8fedb26e-1551-41f7-8750-780f01bbf43e" }
                });
        }
    }
}
