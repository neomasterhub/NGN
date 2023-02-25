using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class Audit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ngn");

            migrationBuilder.RenameTable(
                name: "AuditEvent",
                schema: "mr.apelsin",
                newName: "AuditEvent",
                newSchema: "ngn");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "mr.apelsin");

            migrationBuilder.RenameTable(
                name: "AuditEvent",
                schema: "ngn",
                newName: "AuditEvent",
                newSchema: "mr.apelsin");
        }
    }
}
