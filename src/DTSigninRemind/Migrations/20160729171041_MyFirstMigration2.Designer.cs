﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DTSigninRemind.Models;

namespace DTSigninRemind.Migrations
{
    [DbContext(typeof(SigninRemindingContext))]
    [Migration("20160729171041_MyFirstMigration2")]
    partial class MyFirstMigration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DTSigninRemind.Models.DailyOne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Conent")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 20);

                    b.Property<string>("CreateBy")
                        .IsRequired();

                    b.Property<DateTime?>("CreateTime")
                        .IsRequired();

                    b.Property<string>("DOtype")
                        .IsRequired();

                    b.Property<string>("UpdateBy");

                    b.Property<DateTime?>("UpdateTime");

                    b.HasKey("Id");

                    b.ToTable("DailyOnes");
                });

            modelBuilder.Entity("DTSigninRemind.Models.SendLogTb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<string>("CorpID")
                        .IsRequired();

                    b.Property<string>("Mobile");

                    b.Property<string>("Msgtype")
                        .IsRequired();

                    b.Property<string>("PushType")
                        .IsRequired();

                    b.Property<bool?>("SendState");

                    b.Property<DateTime?>("SendTime");

                    b.Property<string>("Userid")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("SendLogTbs");
                });

            modelBuilder.Entity("DTSigninRemind.Models.SigninRemind", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Avatar");

                    b.Property<string>("Department");

                    b.Property<string>("DeviceId");

                    b.Property<bool>("IsAdmin");

                    b.Property<bool>("IsBoss");

                    b.Property<bool>("IsEnable");

                    b.Property<string>("IsLeaderInDepts");

                    b.Property<bool>("Is_sys");

                    b.Property<string>("Mobile");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("OffRemind");

                    b.Property<TimeSpan?>("OffTime")
                        .IsRequired();

                    b.Property<string>("Position");

                    b.Property<DateTime?>("RegDateTime");

                    b.Property<string>("RemindMode")
                        .IsRequired();

                    b.Property<string>("Sys_level");

                    b.Property<string>("Userid")
                        .IsRequired();

                    b.Property<int>("WorkRemind");

                    b.Property<TimeSpan?>("WorkTime")
                        .IsRequired();

                    b.Property<string>("_OffRemind")
                        .IsRequired();

                    b.Property<string>("_WorkRemind")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("SigninReminds");
                });
        }
    }
}
