using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HealthWebApp2._0.Data.Migrations
{
    public partial class EmergencyContactInfoAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmergencyContactNumber",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmergencyContactPerson",
                table: "People",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RelationshipToPatient",
                table: "People",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmergencyContactNumber",
                table: "People");

            migrationBuilder.DropColumn(
                name: "EmergencyContactPerson",
                table: "People");

            migrationBuilder.DropColumn(
                name: "RelationshipToPatient",
                table: "People");
        }
    }
}
