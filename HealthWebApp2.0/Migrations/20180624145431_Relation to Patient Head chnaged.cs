using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace HealthWebApp2._0.Migrations
{
    public partial class RelationtoPatientHeadchnaged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RelationshipToPatient",
                table: "People",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RelationshipToPatient",
                table: "People",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
