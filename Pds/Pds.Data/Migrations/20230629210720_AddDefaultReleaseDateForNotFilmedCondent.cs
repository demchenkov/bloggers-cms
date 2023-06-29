﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pds.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDefaultReleaseDateForNotFilmedCondent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "CreatedAt", "Description", "Key", "UpdatedAt", "Value" },
                values: new object[] { new Guid("7bb23fa2-4b73-4a3f-c3d4-08d8d2705c5f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Значение по умолчанию даты выхода неснятого контента", "NotFilmedContentDefaultReleaseDate", null, "12/14/2030" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: new Guid("7bb23fa2-4b73-4a3f-c3d4-08d8d2705c5f"));
        }
    }
}
