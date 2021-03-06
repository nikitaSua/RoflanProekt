// <auto-generated />
using System;
using DAL.DBExt;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(ProtalDbContext))]
    [Migration("20210717135807_changeVideo")]
    partial class changeVideo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("shc")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DAL.Entities.Autor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Autors");
                });

            modelBuilder.Entity("DAL.Entities.AutorBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AutorId")
                        .HasColumnType("int");

                    b.Property<int?>("BookId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AutorId");

                    b.HasIndex("BookId");

                    b.ToTable("AutorBook");
                });

            modelBuilder.Entity("DAL.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("DAL.Entities.CourseMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("MaterialId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("MaterialId");

                    b.ToTable("CourseMaterials");
                });

            modelBuilder.Entity("DAL.Entities.CourseUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("UserId");

                    b.ToTable("CourseUsers");
                });

            modelBuilder.Entity("DAL.Entities.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(240)
                        .HasColumnType("nvarchar(240)")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasColumnName("Name");

                    b.HasKey("Id")
                        .IsClustered();

                    b.ToTable("Materials", "sch");
                });

            modelBuilder.Entity("DAL.Entities.MaterialSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Level")
                        .HasColumnType("int")
                        .HasColumnName("Level");

                    b.Property<int?>("MaterialId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("SkillId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_MaterialSkill")
                        .IsClustered();

                    b.HasIndex("MaterialId");

                    b.HasIndex("SkillId");

                    b.ToTable("MaterialSkill", "sch");
                });

            modelBuilder.Entity("DAL.Entities.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("Name");

                    b.HasKey("Id")
                        .HasName("PK_Role")
                        .IsClustered();

                    b.ToTable("Roles", "sch");
                });

            modelBuilder.Entity("DAL.Entities.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("Name");

                    b.HasKey("Id")
                        .HasName("PK_Skill")
                        .IsClustered();

                    b.ToTable("Skills", "sch");
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("Email");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("Login");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasColumnName("Name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("Password");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK_Users")
                        .IsClustered();

                    b.HasIndex("RoleId");

                    b.ToTable("Users", "sch");
                });

            modelBuilder.Entity("DAL.Entities.UserSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Level")
                        .HasColumnType("int")
                        .HasColumnName("Level");

                    b.Property<int?>("SkillId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("SkillId");

                    b.Property<int?>("UserId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("UserId");

                    b.HasKey("Id")
                        .HasName("PK_UserSkill")
                        .IsClustered();

                    b.HasIndex("SkillId");

                    b.HasIndex("UserId");

                    b.ToTable("UserSkill", "sch");
                });

            modelBuilder.Entity("DAL.Entities.Article", b =>
                {
                    b.HasBaseType("DAL.Entities.Material");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasColumnName("Link");

                    b.Property<DateTime>("PublicationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("PublicationDate");

                    b.ToTable("Articles", "sch");
                });

            modelBuilder.Entity("DAL.Entities.Book", b =>
                {
                    b.HasBaseType("DAL.Entities.Material");

                    b.Property<int>("NumOfPage")
                        .HasColumnType("int")
                        .HasColumnName("NumOfPage");

                    b.Property<int>("YearOfPublishing")
                        .HasColumnType("int")
                        .HasColumnName("YearOfPublishing");

                    b.ToTable("Books", "sch");
                });

            modelBuilder.Entity("DAL.Entities.Video", b =>
                {
                    b.HasBaseType("DAL.Entities.Material");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Duration");

                    b.Property<string>("Quality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Quality");

                    b.ToTable("Videos", "sch");
                });

            modelBuilder.Entity("DAL.Entities.AutorBook", b =>
                {
                    b.HasOne("DAL.Entities.Autor", "Autor")
                        .WithMany("AutorBooks")
                        .HasForeignKey("AutorId");

                    b.HasOne("DAL.Entities.Book", "Book")
                        .WithMany("AutorBooks")
                        .HasForeignKey("BookId")
                        .HasConstraintName("FK_AuthorBook_Book")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("DAL.Entities.CourseMaterial", b =>
                {
                    b.HasOne("DAL.Entities.Course", "Course")
                        .WithMany("CourseMaterials")
                        .HasForeignKey("CourseId");

                    b.HasOne("DAL.Entities.Material", "Material")
                        .WithMany("CourseMaterials")
                        .HasForeignKey("MaterialId");

                    b.Navigation("Course");

                    b.Navigation("Material");
                });

            modelBuilder.Entity("DAL.Entities.CourseUser", b =>
                {
                    b.HasOne("DAL.Entities.Course", "Course")
                        .WithMany("CourseUsers")
                        .HasForeignKey("CourseId");

                    b.HasOne("DAL.Entities.User", "User")
                        .WithMany("CourseUser")
                        .HasForeignKey("UserId");

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Entities.MaterialSkill", b =>
                {
                    b.HasOne("DAL.Entities.Material", "Material")
                        .WithMany("MaterialSkills")
                        .HasForeignKey("MaterialId")
                        .HasConstraintName("FK_MaterialSkill_Material")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Skill", "Skill")
                        .WithMany("MaterialSkills")
                        .HasForeignKey("SkillId")
                        .HasConstraintName("FK_MaterialSkill_Skill")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Material");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.HasOne("DAL.Entities.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_User_Role")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DAL.Entities.UserSkill", b =>
                {
                    b.HasOne("DAL.Entities.Skill", "Skill")
                        .WithMany("UserSkills")
                        .HasForeignKey("SkillId")
                        .HasConstraintName("FK_Skill_UserSkill")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DAL.Entities.User", "User")
                        .WithMany("UserSkill")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Users_UserSkill")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Skill");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Entities.Article", b =>
                {
                    b.HasOne("DAL.Entities.Material", null)
                        .WithOne()
                        .HasForeignKey("DAL.Entities.Article", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Entities.Book", b =>
                {
                    b.HasOne("DAL.Entities.Material", null)
                        .WithOne()
                        .HasForeignKey("DAL.Entities.Book", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Entities.Video", b =>
                {
                    b.HasOne("DAL.Entities.Material", null)
                        .WithOne()
                        .HasForeignKey("DAL.Entities.Video", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Entities.Autor", b =>
                {
                    b.Navigation("AutorBooks");
                });

            modelBuilder.Entity("DAL.Entities.Course", b =>
                {
                    b.Navigation("CourseMaterials");

                    b.Navigation("CourseUsers");
                });

            modelBuilder.Entity("DAL.Entities.Material", b =>
                {
                    b.Navigation("CourseMaterials");

                    b.Navigation("MaterialSkills");
                });

            modelBuilder.Entity("DAL.Entities.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("DAL.Entities.Skill", b =>
                {
                    b.Navigation("MaterialSkills");

                    b.Navigation("UserSkills");
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.Navigation("CourseUser");

                    b.Navigation("UserSkill");
                });

            modelBuilder.Entity("DAL.Entities.Book", b =>
                {
                    b.Navigation("AutorBooks");
                });
#pragma warning restore 612, 618
        }
    }
}
