﻿// <auto-generated />
using System;
using MVC_lab_3___4.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_lab_3___4.Migrations
{
    [DbContext(typeof(MVC_lab_DBcontext))]
    [Migration("20230930203339_tempmigration2")]
    partial class tempmigration2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CourseDepartment", b =>
                {
                    b.Property<int>("CoursesID")
                        .HasColumnType("int");

                    b.Property<int>("departmentsID")
                        .HasColumnType("int");

                    b.HasKey("CoursesID", "departmentsID");

                    b.HasIndex("departmentsID");

                    b.ToTable("CourseDepartment");
                });

            modelBuilder.Entity("DepartmentInstructor", b =>
                {
                    b.Property<int>("DepartmentsID")
                        .HasColumnType("int");

                    b.Property<int>("InstructorsID")
                        .HasColumnType("int");

                    b.HasKey("DepartmentsID", "InstructorsID");

                    b.HasIndex("InstructorsID");

                    b.ToTable("DepartmentInstructor");
                });

            modelBuilder.Entity("MVC_lab_3___4.Models.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("InstructorId");

                    b.ToTable("courses");
                });

            modelBuilder.Entity("MVC_lab_3___4.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("MVC_lab_3___4.Models.Instructor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("MVC_lab_3___4.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("DeptNo")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("DeptNo");

                    b.ToTable("students");
                });

            modelBuilder.Entity("MVC_lab_3___4.Models.StudentCourse", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("degree")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("CourseDepartment", b =>
                {
                    b.HasOne("MVC_lab_3___4.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_lab_3___4.Models.Department", null)
                        .WithMany()
                        .HasForeignKey("departmentsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DepartmentInstructor", b =>
                {
                    b.HasOne("MVC_lab_3___4.Models.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_lab_3___4.Models.Instructor", null)
                        .WithMany()
                        .HasForeignKey("InstructorsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC_lab_3___4.Models.Course", b =>
                {
                    b.HasOne("MVC_lab_3___4.Models.Instructor", "Instructor")
                        .WithMany("Courses")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("MVC_lab_3___4.Models.Student", b =>
                {
                    b.HasOne("MVC_lab_3___4.Models.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DeptNo");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("MVC_lab_3___4.Models.StudentCourse", b =>
                {
                    b.HasOne("MVC_lab_3___4.Models.Course", "course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_lab_3___4.Models.Student", "student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("course");

                    b.Navigation("student");
                });

            modelBuilder.Entity("MVC_lab_3___4.Models.Course", b =>
                {
                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("MVC_lab_3___4.Models.Department", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("MVC_lab_3___4.Models.Instructor", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("MVC_lab_3___4.Models.Student", b =>
                {
                    b.Navigation("StudentCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
