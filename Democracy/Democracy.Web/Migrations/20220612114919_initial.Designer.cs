﻿// <auto-generated />
using System;
using Democracy.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Democracy.Web.Migrations
{
    [DbContext(typeof(PollsContext))]
    [Migration("20220612114919_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Democracy.Web.Domain.Attribute", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Attributes");
                });

            modelBuilder.Entity("Democracy.Web.Domain.AttributeCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Descrption")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("AttributeCategories");
                });

            modelBuilder.Entity("Democracy.Web.Domain.Poll", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset>("CreationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("LiveParticipants")
                        .HasColumnType("boolean");

                    b.Property<bool>("LiveResults")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTimeOffset?>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("TypeId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TypeId");

                    b.ToTable("Polls");
                });

            modelBuilder.Entity("Democracy.Web.Domain.PollAttributeValue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AttributeId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PollId")
                        .HasColumnType("uuid");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AttributeId");

                    b.HasIndex("PollId");

                    b.ToTable("PollAttributeValues");
                });

            modelBuilder.Entity("Democracy.Web.Domain.PollCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PollCategories");
                });

            modelBuilder.Entity("Democracy.Web.Domain.PollQuestion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Condition")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ContentUrl")
                        .HasColumnType("text");

                    b.Property<int>("Index")
                        .HasColumnType("integer");

                    b.Property<int?>("Max")
                        .HasColumnType("integer");

                    b.Property<int?>("Min")
                        .HasColumnType("integer");

                    b.Property<Guid>("PollId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PollId");

                    b.HasIndex("QuestionId");

                    b.ToTable("PollQuestion");
                });

            modelBuilder.Entity("Democracy.Web.Domain.PollQuestionOption", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ContentUrl")
                        .HasColumnType("text");

                    b.Property<int>("Index")
                        .HasColumnType("integer");

                    b.Property<Guid>("PollId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("PollQuestionId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("QuestionOptionId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PollId");

                    b.HasIndex("PollQuestionId");

                    b.HasIndex("QuestionOptionId");

                    b.ToTable("PollQuestionOption");
                });

            modelBuilder.Entity("Democracy.Web.Domain.PollSession", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<Guid>("PollId")
                        .HasColumnType("uuid");

                    b.Property<DateTimeOffset?>("SessionFinished")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("SessionStarted")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("PollId");

                    b.ToTable("PollSessions");
                });

            modelBuilder.Entity("Democracy.Web.Domain.PollType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("PollTypes");
                });

            modelBuilder.Entity("Democracy.Web.Domain.Question", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ContentUrl")
                        .HasColumnType("text");

                    b.Property<int>("QuestionType")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Democracy.Web.Domain.QuestionOption", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ContentUrl")
                        .HasColumnType("text");

                    b.Property<int>("Index")
                        .HasColumnType("integer");

                    b.Property<Guid>("QuestionId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionOptions");
                });

            modelBuilder.Entity("Democracy.Web.Domain.Attribute", b =>
                {
                    b.HasOne("Democracy.Web.Domain.AttributeCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Democracy.Web.Domain.AttributeCategory", b =>
                {
                    b.HasOne("Democracy.Web.Domain.AttributeCategory", "Parent")
                        .WithMany("Related")
                        .HasForeignKey("ParentId");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("Democracy.Web.Domain.Poll", b =>
                {
                    b.HasOne("Democracy.Web.Domain.PollCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Democracy.Web.Domain.PollType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("Democracy.Web.Domain.PollAttributeValue", b =>
                {
                    b.HasOne("Democracy.Web.Domain.Attribute", "Attribute")
                        .WithMany()
                        .HasForeignKey("AttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Democracy.Web.Domain.Poll", "Poll")
                        .WithMany("AttributeValues")
                        .HasForeignKey("PollId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attribute");

                    b.Navigation("Poll");
                });

            modelBuilder.Entity("Democracy.Web.Domain.PollQuestion", b =>
                {
                    b.HasOne("Democracy.Web.Domain.Poll", "Poll")
                        .WithMany("Questions")
                        .HasForeignKey("PollId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Democracy.Web.Domain.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Poll");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Democracy.Web.Domain.PollQuestionOption", b =>
                {
                    b.HasOne("Democracy.Web.Domain.Poll", "Poll")
                        .WithMany()
                        .HasForeignKey("PollId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Democracy.Web.Domain.PollQuestion", null)
                        .WithMany("QuestionOptions")
                        .HasForeignKey("PollQuestionId");

                    b.HasOne("Democracy.Web.Domain.QuestionOption", "QuestionOption")
                        .WithMany()
                        .HasForeignKey("QuestionOptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Poll");

                    b.Navigation("QuestionOption");
                });

            modelBuilder.Entity("Democracy.Web.Domain.PollSession", b =>
                {
                    b.HasOne("Democracy.Web.Domain.Poll", "Poll")
                        .WithMany()
                        .HasForeignKey("PollId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Poll");
                });

            modelBuilder.Entity("Democracy.Web.Domain.QuestionOption", b =>
                {
                    b.HasOne("Democracy.Web.Domain.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Democracy.Web.Domain.AttributeCategory", b =>
                {
                    b.Navigation("Related");
                });

            modelBuilder.Entity("Democracy.Web.Domain.Poll", b =>
                {
                    b.Navigation("AttributeValues");

                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Democracy.Web.Domain.PollQuestion", b =>
                {
                    b.Navigation("QuestionOptions");
                });
#pragma warning restore 612, 618
        }
    }
}