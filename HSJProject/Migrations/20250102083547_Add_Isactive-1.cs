﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HSJProject.Migrations
{
    /// <inheritdoc />
    public partial class Add_Isactive1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "SocialLink");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "SocialLink",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}