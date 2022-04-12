﻿// <auto-generated />
using System;
using API_MySIRH.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API_MySIRH.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220411150934_InitialCreateone")]
    partial class InitialCreateone
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("API_MySIRH.Entities.Collaborater", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Agency")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Civility")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOf1stExperience")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Diplomas")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("InternshipStartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Post")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RegistrationNumber")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("SkillsCenter")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TypeOfContract")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Collaborators");
                });

            modelBuilder.Entity("API_MySIRH.Entities.Memo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("HtmlContent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Memos");
                });

            modelBuilder.Entity("API_MySIRH.Entities.ToDoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Ordre")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Statut")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ToDoListId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ToDoListId");

                    b.ToTable("ToDoItems");
                });

            modelBuilder.Entity("API_MySIRH.Entities.ToDoList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("Ordre")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ToDoLists");
                });

            modelBuilder.Entity("API_MySIRH.Entities.ToDoItem", b =>
                {
                    b.HasOne("API_MySIRH.Entities.ToDoList", "ToDoList")
                        .WithMany("ToDoItemList")
                        .HasForeignKey("ToDoListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ToDoList");
                });

            modelBuilder.Entity("API_MySIRH.Entities.ToDoList", b =>
                {
                    b.Navigation("ToDoItemList");
                });
#pragma warning restore 612, 618
        }
    }
}