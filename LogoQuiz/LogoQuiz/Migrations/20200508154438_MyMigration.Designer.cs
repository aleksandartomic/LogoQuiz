﻿// <auto-generated />
using LogoQuiz.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LogoQuiz.Migrations
{
    [DbContext(typeof(Repository))]
    [Migration("20200508154438_MyMigration")]
    partial class MyMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("LogoQuiz.Models.Logo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Hint")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsSucceed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Level")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Point")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Logos");

                    b.HasData(
                        new
                        {
                            Id = "CDAD889AE72F4DB7A58AE778B4C427E0",
                            Hint = "A*p***",
                            ImageUrl = "APPLE.png",
                            IsSucceed = false,
                            Level = "Level 1",
                            Name = "Apple",
                            Point = 0
                        },
                        new
                        {
                            Id = "CE823A60773849058541ABA774D04188",
                            Hint = "Fa*e**o*",
                            ImageUrl = "FACEBOOK.png",
                            IsSucceed = false,
                            Level = "Level 1",
                            Name = "Facebook",
                            Point = 0
                        },
                        new
                        {
                            Id = "DBCCB202A0CE4CFDB2EF3F5248724414",
                            Hint = "G**gl* C***me",
                            ImageUrl = "GOOGLECHROME.png",
                            IsSucceed = false,
                            Level = "Level 2",
                            Name = "Google Chrome",
                            Point = 0
                        },
                        new
                        {
                            Id = "B74B052F9A1F4A0CB05151605FA3D4C5",
                            Hint = "H****i",
                            ImageUrl = "HUAWEI.png",
                            IsSucceed = false,
                            Level = "Level 1",
                            Name = "Huawei",
                            Point = 0
                        },
                        new
                        {
                            Id = "071B4C0A35684F25B7DCA3F0D537F476",
                            Hint = "I***ag**m",
                            ImageUrl = "INSTAGRAM.png",
                            IsSucceed = false,
                            Level = "Level 1",
                            Name = "Instagram",
                            Point = 0
                        },
                        new
                        {
                            Id = "C25DA2E15F0B418D9DCFF1B3060456B9",
                            Hint = "M***e**s",
                            ImageUrl = "MERCEDES.png",
                            IsSucceed = false,
                            Level = "Level 1",
                            Name = "Mercedes",
                            Point = 0
                        },
                        new
                        {
                            Id = "C16684964C424EE19CEB63D376DB1B10",
                            Hint = "*a***ng",
                            ImageUrl = "SAMSUNG.png",
                            IsSucceed = false,
                            Level = "Level 2",
                            Name = "Samsung",
                            Point = 0
                        },
                        new
                        {
                            Id = "DDFEE56CA8864BD687D2AC32C32D21D2",
                            Hint = "Sk**e",
                            ImageUrl = "SKYPE.png",
                            IsSucceed = false,
                            Level = "Level 2",
                            Name = "Skype",
                            Point = 0
                        },
                        new
                        {
                            Id = "8AD2F5DC072244AC8C3A90812C7BD37F",
                            Hint = "*****er",
                            ImageUrl = "TWITTER.png",
                            IsSucceed = false,
                            Level = "Level 2",
                            Name = "Twitter",
                            Point = 0
                        },
                        new
                        {
                            Id = "E17F096E70EF47788CB828EA7E0D984C",
                            Hint = "Y*u*T***",
                            ImageUrl = "YOUTUBE.png",
                            IsSucceed = false,
                            Level = "Level 2",
                            Name = "YouTube",
                            Point = 0
                        },
                        new
                        {
                            Id = "9A265275C8F449A9A388CFFE6A270D70",
                            Hint = "BMW",
                            ImageUrl = "BMW.jpg",
                            IsSucceed = false,
                            Level = "Level 1",
                            Name = "BMW",
                            Point = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}