using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class chengeContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutorBook_Autor_AutorId",
                schema: "shc",
                table: "AutorBook");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseMaterial_Course_CourseId",
                schema: "shc",
                table: "CourseMaterial");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseMaterial_Materials_MaterialId",
                schema: "shc",
                table: "CourseMaterial");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseUser_Course_CourseId",
                schema: "shc",
                table: "CourseUser");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseUser_Users_UserId",
                schema: "shc",
                table: "CourseUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseUser",
                schema: "shc",
                table: "CourseUser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseMaterial",
                schema: "shc",
                table: "CourseMaterial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                schema: "shc",
                table: "Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Autor",
                schema: "shc",
                table: "Autor");

            migrationBuilder.RenameTable(
                name: "CourseUser",
                schema: "shc",
                newName: "CourseUsers",
                newSchema: "shc");

            migrationBuilder.RenameTable(
                name: "CourseMaterial",
                schema: "shc",
                newName: "CourseMaterials",
                newSchema: "shc");

            migrationBuilder.RenameTable(
                name: "Course",
                schema: "shc",
                newName: "Courses",
                newSchema: "shc");

            migrationBuilder.RenameTable(
                name: "Autor",
                schema: "shc",
                newName: "Autors",
                newSchema: "shc");

            migrationBuilder.RenameIndex(
                name: "IX_CourseUser_UserId",
                schema: "shc",
                table: "CourseUsers",
                newName: "IX_CourseUsers_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseUser_CourseId",
                schema: "shc",
                table: "CourseUsers",
                newName: "IX_CourseUsers_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseMaterial_MaterialId",
                schema: "shc",
                table: "CourseMaterials",
                newName: "IX_CourseMaterials_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseMaterial_CourseId",
                schema: "shc",
                table: "CourseMaterials",
                newName: "IX_CourseMaterials_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseUsers",
                schema: "shc",
                table: "CourseUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseMaterials",
                schema: "shc",
                table: "CourseMaterials",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                schema: "shc",
                table: "Courses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autors",
                schema: "shc",
                table: "Autors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AutorBook_Autors_AutorId",
                schema: "shc",
                table: "AutorBook",
                column: "AutorId",
                principalSchema: "shc",
                principalTable: "Autors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseMaterials_Courses_CourseId",
                schema: "shc",
                table: "CourseMaterials",
                column: "CourseId",
                principalSchema: "shc",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseMaterials_Materials_MaterialId",
                schema: "shc",
                table: "CourseMaterials",
                column: "MaterialId",
                principalSchema: "sch",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseUsers_Courses_CourseId",
                schema: "shc",
                table: "CourseUsers",
                column: "CourseId",
                principalSchema: "shc",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseUsers_Users_UserId",
                schema: "shc",
                table: "CourseUsers",
                column: "UserId",
                principalSchema: "sch",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AutorBook_Autors_AutorId",
                schema: "shc",
                table: "AutorBook");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseMaterials_Courses_CourseId",
                schema: "shc",
                table: "CourseMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseMaterials_Materials_MaterialId",
                schema: "shc",
                table: "CourseMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseUsers_Courses_CourseId",
                schema: "shc",
                table: "CourseUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseUsers_Users_UserId",
                schema: "shc",
                table: "CourseUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseUsers",
                schema: "shc",
                table: "CourseUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                schema: "shc",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseMaterials",
                schema: "shc",
                table: "CourseMaterials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Autors",
                schema: "shc",
                table: "Autors");

            migrationBuilder.RenameTable(
                name: "CourseUsers",
                schema: "shc",
                newName: "CourseUser",
                newSchema: "shc");

            migrationBuilder.RenameTable(
                name: "Courses",
                schema: "shc",
                newName: "Course",
                newSchema: "shc");

            migrationBuilder.RenameTable(
                name: "CourseMaterials",
                schema: "shc",
                newName: "CourseMaterial",
                newSchema: "shc");

            migrationBuilder.RenameTable(
                name: "Autors",
                schema: "shc",
                newName: "Autor",
                newSchema: "shc");

            migrationBuilder.RenameIndex(
                name: "IX_CourseUsers_UserId",
                schema: "shc",
                table: "CourseUser",
                newName: "IX_CourseUser_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseUsers_CourseId",
                schema: "shc",
                table: "CourseUser",
                newName: "IX_CourseUser_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseMaterials_MaterialId",
                schema: "shc",
                table: "CourseMaterial",
                newName: "IX_CourseMaterial_MaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseMaterials_CourseId",
                schema: "shc",
                table: "CourseMaterial",
                newName: "IX_CourseMaterial_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseUser",
                schema: "shc",
                table: "CourseUser",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                schema: "shc",
                table: "Course",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseMaterial",
                schema: "shc",
                table: "CourseMaterial",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autor",
                schema: "shc",
                table: "Autor",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AutorBook_Autor_AutorId",
                schema: "shc",
                table: "AutorBook",
                column: "AutorId",
                principalSchema: "shc",
                principalTable: "Autor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseMaterial_Course_CourseId",
                schema: "shc",
                table: "CourseMaterial",
                column: "CourseId",
                principalSchema: "shc",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseMaterial_Materials_MaterialId",
                schema: "shc",
                table: "CourseMaterial",
                column: "MaterialId",
                principalSchema: "sch",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseUser_Course_CourseId",
                schema: "shc",
                table: "CourseUser",
                column: "CourseId",
                principalSchema: "shc",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseUser_Users_UserId",
                schema: "shc",
                table: "CourseUser",
                column: "UserId",
                principalSchema: "sch",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
