﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DCandidate",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    mobile = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    age = table.Column<int>(nullable: false),
                    bloodGroup = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DCandidate", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DCandidate");
        }
    }
}
