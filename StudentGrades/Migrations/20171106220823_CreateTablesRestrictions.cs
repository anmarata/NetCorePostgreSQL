using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StudentGrades.Migrations
{
    public partial class CreateTablesRestrictions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Grades",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Grades_StudentId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Grades");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "student");

            migrationBuilder.RenameTable(
                name: "Grades",
                newName: "grade");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "student",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Activo",
                table: "student",
                newName: "activo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "student",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "grade",
                newName: "subject");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "grade",
                newName: "studentid");

            migrationBuilder.RenameColumn(
                name: "GradeNumber",
                table: "grade",
                newName: "gradenumber");

            migrationBuilder.AlterColumn<string>(
                name: "subject",
                table: "grade",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_student",
                table: "student",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_grade",
                table: "grade",
                columns: new[] { "studentid", "subject" });

            migrationBuilder.AddForeignKey(
                name: "FK_grade_student_studentid",
                table: "grade",
                column: "studentid",
                principalTable: "student",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_grade_student_studentid",
                table: "grade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_student",
                table: "student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_grade",
                table: "grade");

            migrationBuilder.RenameTable(
                name: "student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "grade",
                newName: "Grades");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Students",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "activo",
                table: "Students",
                newName: "Activo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Students",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "gradenumber",
                table: "Grades",
                newName: "GradeNumber");

            migrationBuilder.RenameColumn(
                name: "subject",
                table: "Grades",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "studentid",
                table: "Grades",
                newName: "StudentId");

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "Grades",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Grades",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Grades",
                table: "Grades",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Students_StudentId",
                table: "Grades",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
