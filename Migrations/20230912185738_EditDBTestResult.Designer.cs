﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuizAPI;

#nullable disable

namespace QuizAPI.Migrations
{
    [DbContext(typeof(QuizContext))]
    [Migration("20230912185738_EditDBTestResult")]
    partial class EditDBTestResult
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("QuizAPI.Models.Answer", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsRightAnswer")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("AnswerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            AnswerId = 1,
                            Description = "17",
                            IsRightAnswer = false,
                            QuestionId = 3
                        },
                        new
                        {
                            AnswerId = 2,
                            Description = "21",
                            IsRightAnswer = false,
                            QuestionId = 3
                        },
                        new
                        {
                            AnswerId = 3,
                            Description = "25",
                            IsRightAnswer = true,
                            QuestionId = 3
                        },
                        new
                        {
                            AnswerId = 5,
                            Description = "Best of 3",
                            IsRightAnswer = false,
                            QuestionId = 4
                        },
                        new
                        {
                            AnswerId = 6,
                            Description = "Best of 5",
                            IsRightAnswer = true,
                            QuestionId = 4
                        },
                        new
                        {
                            AnswerId = 7,
                            Description = "Best of 7",
                            IsRightAnswer = false,
                            QuestionId = 4
                        },
                        new
                        {
                            AnswerId = 8,
                            Description = "8x8",
                            IsRightAnswer = false,
                            QuestionId = 1
                        },
                        new
                        {
                            AnswerId = 9,
                            Description = "9x9",
                            IsRightAnswer = true,
                            QuestionId = 1
                        },
                        new
                        {
                            AnswerId = 10,
                            Description = "7x7",
                            IsRightAnswer = false,
                            QuestionId = 1
                        },
                        new
                        {
                            AnswerId = 11,
                            Description = "Yes",
                            IsRightAnswer = true,
                            QuestionId = 2
                        },
                        new
                        {
                            AnswerId = 12,
                            Description = "No",
                            IsRightAnswer = false,
                            QuestionId = 2
                        },
                        new
                        {
                            AnswerId = 13,
                            Description = "Monte Carlo",
                            IsRightAnswer = true,
                            QuestionId = 5
                        },
                        new
                        {
                            AnswerId = 14,
                            Description = "Rome",
                            IsRightAnswer = false,
                            QuestionId = 5
                        },
                        new
                        {
                            AnswerId = 15,
                            Description = "Budapest",
                            IsRightAnswer = false,
                            QuestionId = 5
                        },
                        new
                        {
                            AnswerId = 16,
                            Description = "Red Bull Racing",
                            IsRightAnswer = true,
                            QuestionId = 6
                        },
                        new
                        {
                            AnswerId = 17,
                            Description = "Aston Martin",
                            IsRightAnswer = false,
                            QuestionId = 6
                        },
                        new
                        {
                            AnswerId = 18,
                            Description = "Sauber",
                            IsRightAnswer = false,
                            QuestionId = 6
                        },
                        new
                        {
                            AnswerId = 19,
                            Description = "Valtteri Bottas",
                            IsRightAnswer = false,
                            QuestionId = 8
                        },
                        new
                        {
                            AnswerId = 20,
                            Description = "Kimi Räikkönen",
                            IsRightAnswer = true,
                            QuestionId = 8
                        },
                        new
                        {
                            AnswerId = 21,
                            Description = "Halo",
                            IsRightAnswer = true,
                            QuestionId = 7
                        },
                        new
                        {
                            AnswerId = 22,
                            Description = "Fuel sensor",
                            IsRightAnswer = false,
                            QuestionId = 7
                        },
                        new
                        {
                            AnswerId = 23,
                            Description = "10080",
                            IsRightAnswer = true,
                            QuestionId = 9
                        },
                        new
                        {
                            AnswerId = 24,
                            Description = "10820",
                            IsRightAnswer = false,
                            QuestionId = 9
                        },
                        new
                        {
                            AnswerId = 25,
                            Description = "11800",
                            IsRightAnswer = false,
                            QuestionId = 9
                        },
                        new
                        {
                            AnswerId = 26,
                            Description = "118",
                            IsRightAnswer = true,
                            QuestionId = 10
                        },
                        new
                        {
                            AnswerId = 27,
                            Description = "120",
                            IsRightAnswer = false,
                            QuestionId = 10
                        },
                        new
                        {
                            AnswerId = 28,
                            Description = "3",
                            IsRightAnswer = true,
                            QuestionId = 11
                        },
                        new
                        {
                            AnswerId = 29,
                            Description = "4",
                            IsRightAnswer = false,
                            QuestionId = 11
                        },
                        new
                        {
                            AnswerId = 30,
                            Description = "5",
                            IsRightAnswer = false,
                            QuestionId = 11
                        },
                        new
                        {
                            AnswerId = 31,
                            Description = "16",
                            IsRightAnswer = false,
                            QuestionId = 12
                        },
                        new
                        {
                            AnswerId = 32,
                            Description = "20",
                            IsRightAnswer = false,
                            QuestionId = 12
                        },
                        new
                        {
                            AnswerId = 33,
                            Description = "12",
                            IsRightAnswer = true,
                            QuestionId = 12
                        });
                });

            modelBuilder.Entity("QuizAPI.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("QuestionId");

                    b.HasIndex("TestId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            QuestionId = 1,
                            TestId = 1,
                            Title = "How large is a volleyball court?"
                        },
                        new
                        {
                            QuestionId = 2,
                            TestId = 1,
                            Title = "Can you touch the ball with your feet?"
                        },
                        new
                        {
                            QuestionId = 3,
                            TestId = 1,
                            Title = "How many points does a set have?"
                        },
                        new
                        {
                            QuestionId = 4,
                            TestId = 1,
                            Title = "What is the winning formula in a standard match??"
                        },
                        new
                        {
                            QuestionId = 5,
                            TestId = 2,
                            Title = "Which city hosts the Monaco Grand Prix?"
                        },
                        new
                        {
                            QuestionId = 6,
                            TestId = 2,
                            Title = "Which F1 constructor is based in Milton Keynes, England?"
                        },
                        new
                        {
                            QuestionId = 7,
                            TestId = 2,
                            Title = "What is the name of the F1 car's protective structure that is designed to protect the driver's head in the event of an accident?"
                        },
                        new
                        {
                            QuestionId = 8,
                            TestId = 2,
                            Title = "“The Iceman” is the nickname given to which Finnish Formula 1 World Champion??"
                        },
                        new
                        {
                            QuestionId = 9,
                            TestId = 3,
                            Title = "How many minutes are in a full week?"
                        },
                        new
                        {
                            QuestionId = 10,
                            TestId = 3,
                            Title = "How many elements are in the periodic table?"
                        },
                        new
                        {
                            QuestionId = 11,
                            TestId = 3,
                            Title = "How many bones do we have in an ear?"
                        },
                        new
                        {
                            QuestionId = 12,
                            TestId = 3,
                            Title = "How many faces does a Dodecahedron have?"
                        });
                });

            modelBuilder.Entity("QuizAPI.Models.Test", b =>
                {
                    b.Property<int>("TestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("TestName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TestId");

                    b.ToTable("Tests");

                    b.HasData(
                        new
                        {
                            TestId = 1,
                            TestName = "Volleyball"
                        },
                        new
                        {
                            TestId = 2,
                            TestName = "Formula 1"
                        },
                        new
                        {
                            TestId = 3,
                            TestName = "Numbers"
                        });
                });

            modelBuilder.Entity("QuizAPI.Models.TestResult", b =>
                {
                    b.Property<int>("TestResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime?>("ResultDate")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("ResultPercentage")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("TestId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("TestResultId");

                    b.HasIndex("TestId");

                    b.HasIndex("UserId");

                    b.ToTable("TestResults");
                });

            modelBuilder.Entity("QuizAPI.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            UserName = "Alessia"
                        },
                        new
                        {
                            UserId = 2,
                            UserName = "Luigi"
                        });
                });

            modelBuilder.Entity("QuizAPI.Models.UserTestQuestionAnswer", b =>
                {
                    b.Property<int>("UserTestQuestionAnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("AnswerDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("AnswerId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("TestResultId")
                        .HasColumnType("int");

                    b.HasKey("UserTestQuestionAnswerId");

                    b.HasIndex("AnswerId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("TestResultId");

                    b.ToTable("UserTestQuestionAnswers");
                });

            modelBuilder.Entity("QuizAPI.Models.Answer", b =>
                {
                    b.HasOne("QuizAPI.Models.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("QuizAPI.Models.Question", b =>
                {
                    b.HasOne("QuizAPI.Models.Test", "Test")
                        .WithMany("Questions")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Test");
                });

            modelBuilder.Entity("QuizAPI.Models.TestResult", b =>
                {
                    b.HasOne("QuizAPI.Models.Test", "Test")
                        .WithMany()
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuizAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Test");

                    b.Navigation("User");
                });

            modelBuilder.Entity("QuizAPI.Models.UserTestQuestionAnswer", b =>
                {
                    b.HasOne("QuizAPI.Models.Answer", "Answer")
                        .WithMany()
                        .HasForeignKey("AnswerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuizAPI.Models.Question", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuizAPI.Models.TestResult", "TestResult")
                        .WithMany()
                        .HasForeignKey("TestResultId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Answer");

                    b.Navigation("Question");

                    b.Navigation("TestResult");
                });

            modelBuilder.Entity("QuizAPI.Models.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("QuizAPI.Models.Test", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
