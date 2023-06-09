﻿// <auto-generated />
using System;
using BugTracker.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BugTracker.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220209133556_iur_PJ_Sub")]
    partial class iur_PJ_Sub
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BugTracker.Domain.Entities.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("BugTracker.Domain.Entities.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("BugTracker.Domain.Entities.ProjectTeamMember", b =>
                {
                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ProjectId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("ProjectTeamMembers");
                });

            modelBuilder.Entity("BugTracker.Domain.Entities.Ticket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EstimatedAmountOfHours")
                        .HasColumnType("int");

                    b.Property<Guid?>("LastModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<Guid>("ProjectId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("ProjectId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("BugTracker.Domain.Entities.TicketsTeamMembers", b =>
                {
                    b.Property<Guid>("TicketId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("TicketId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("TicketsTeamMembers");
                });

            modelBuilder.Entity("BugTracker.Domain.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "33113608-2ce2-4da2-a77d-31294998d9fa",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "321966b4-cc40-46fa-a1b8-b6ef054166bc",
                            Email = "DemoAdmin@Admin.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "DEMOADMIN@ADMIN.COM",
                            NormalizedUserName = "DEMO ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEKDZWevQWIvqW96CkSt3OFJTzdnNj+BwFfv3Sv2KPNbQDmzH7qqtzCEVh2qQsWEYRQ==",
                            PhoneNumber = "XXXXXXXXXXXXX",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Demo Admin"
                        },
                        new
                        {
                            Id = "0d882544-b17a-44ca-893d-a1dec8d263bd",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "aa107294-b518-4a11-ae1c-51e652d69e0d",
                            Email = "DemoDev@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "DEMODEV@GMAIL.COM",
                            NormalizedUserName = "DEMO DEVELOPER",
                            PasswordHash = "AQAAAAEAACcQAAAAEMslX4e9ZszLnAqqo9hKG7LtB/BSZcc/Ft+31aWgFI1zwrvh6XYLbVz/ZfN8eH2XUQ==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Demo developer"
                        },
                        new
                        {
                            Id = "c7deddea-55c8-4dd1-ab7f-a69841effbb5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3ca4dc2c-f21b-4c04-b461-28840c77fba6",
                            Email = "john@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "JOHN@GMAIL.COM",
                            NormalizedUserName = "DEMO SUBMITTER",
                            PasswordHash = "AQAAAAEAACcQAAAAEOawT/p04zZVAsXaSnEhByM2HqH7pOs1R1TPhBrbBQyq69Xk0PpA9uEQreGcdc1Vug==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Demo submitter"
                        },
                        new
                        {
                            Id = "4521ea1a-28b0-40c5-9416-b1c692b07061",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "12ff272f-81c0-48bc-ac20-3153e9342ced",
                            Email = "demoPM@gmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "DEMOPM@GMAIL.COM",
                            NormalizedUserName = "DEMO PROJECT MANAGER",
                            PasswordHash = "AQAAAAEAACcQAAAAEKyW0uQORHprLlwAYsjGAcVxH89zLBeph03gp+mMGZf8uJjar/7lcrAsw68J0lZvOg==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Demo Project Manager"
                        },
                        new
                        {
                            Id = "21bbccc8-fc2a-4881-b746-ed9d90fbff9b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ccbcd404-6dcf-4960-b483-2071368066eb",
                            Email = "quentin.coui@hotmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "QUENTIN.COUI@HOTMAIL.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEL1t1FUrZZ/u7Jt0kzDXoFg5xY6K2zK0/lUxzeTmGeC5h42I0fLBlDtMzECX4e08GA==",
                            PhoneNumber = "XXXXXXXXXXXXX",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "355daad8-1cb5-4caa-8538-e82508b5248a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5bf257ef-e05a-491d-ba4c-94d109d39f42",
                            Email = "john.doe@hotmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "JOHN.DOE@HOTMAIL.COM",
                            NormalizedUserName = "JOHN DOE",
                            PasswordHash = "AQAAAAEAACcQAAAAEDJW1ynfoG4k9LennONKBiUSKFW5d/0PsSWPNRdpubuIOmHjW3XIz0gi30yrXksFtQ==",
                            PhoneNumber = "XXXXXXXXXXXXX",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "John doe"
                        },
                        new
                        {
                            Id = "c31a5e3d-a2ef-4065-a12c-2f9647f24070",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2398e0b0-ed2d-46cc-aef4-2234df1e6dd6",
                            Email = "jane.doe@hotmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "JANE.DOE@HOTMAIL.COM",
                            NormalizedUserName = "JANE DOE",
                            PasswordHash = "AQAAAAEAACcQAAAAEIQeTGMbaqEbaUnAsQ8pslEOGpdbhFI514Ofa41+Ik9cfM7tWprkndjsEf/be0hvlQ==",
                            PhoneNumber = "XXXXXXXXXXXXX",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Jane doe"
                        },
                        new
                        {
                            Id = "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "282b898c-a051-4b75-8db0-4c0e160d47de",
                            Email = "jack.nicklefrost@hotmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "JACK.NICKLEFROST@HOTMAIL.COM",
                            NormalizedUserName = "JACK NICKEFROST",
                            PasswordHash = "AQAAAAEAACcQAAAAEKFce9cU/iU+rp/5C3U8BZ9isGR9Ul2NE53jjAFN/RDS6u2vYFrR2NCKUmE6vzdEjA==",
                            PhoneNumber = "XXXXXXXXXXXXX",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Jack nicklefrost"
                        },
                        new
                        {
                            Id = "68f84753-8203-45a0-ac1e-b2a06411d49a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7fc81fbb-3464-4560-8bf6-9d761405618c",
                            Email = "hanna.steinbeck@hotmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "HANNA.STEINBECK@HOTMAIL.COM",
                            NormalizedUserName = "HANNA STEINBECK",
                            PasswordHash = "AQAAAAEAACcQAAAAEHccTeGpG5b2NDYi7mxz1RZMDY78TJmh7qUahw1mTWtoRnLF1+aEQ9VSJnWljdPr+A==",
                            PhoneNumber = "XXXXXXXXXXXXX",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Hanna steinbeck"
                        },
                        new
                        {
                            Id = "b964514f-fc0c-47f2-b16b-dfd7cbf8c167",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f5b765aa-2163-4446-8048-7f41907ab22f",
                            Email = "alice.cooper@hotmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ALICE.COOPER@HOTMAIL.COM",
                            NormalizedUserName = "ALICE COOPER",
                            PasswordHash = "AQAAAAEAACcQAAAAEIh44B+tOtBgnY8lopMt1rZ+/map99NPI+GORmY0emK6rJGo55N3Ans0/JG0ggRYxA==",
                            PhoneNumber = "XXXXXXXXXXXXX",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Alice cooper"
                        },
                        new
                        {
                            Id = "df656ced-7b29-4504-baeb-60d628c56739",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4517a2c8-f8d3-4a72-9df2-cbd0365d83cd",
                            Email = "dean.moriarty@hotmail.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "DEAN.MORIARTY@HOTMAIL.COM",
                            NormalizedUserName = "DEAN MORIARTY",
                            PasswordHash = "AQAAAAEAACcQAAAAEAoFgOdZkH30FQrfrbT2t9DKv/ulACbjvUjal31iqAjiPi0shRifCaLUHWFJao24tw==",
                            PhoneNumber = "XXXXXXXXXXXXX",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "00000000-0000-0000-0000-000000000000",
                            TwoFactorEnabled = false,
                            UserName = "Dean Moriarty"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65",
                            ConcurrencyStamp = "91267d5b-3ba3-4bf1-9a8d-06e0a45e1cd5",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "6e8006e3-e50a-49be-94ea-03ab653713cc",
                            ConcurrencyStamp = "fbb7e5af-2f10-47ef-b18b-bd4b0f2476b4",
                            Name = "Project Manager",
                            NormalizedName = "PROJECT MANAGER"
                        },
                        new
                        {
                            Id = "04614fbc-b0b7-4344-a2e9-8046742ac7cb",
                            ConcurrencyStamp = "f5230756-98df-4545-a2e5-6df4797dac6a",
                            Name = "Developer",
                            NormalizedName = "DEVELOPER"
                        },
                        new
                        {
                            Id = "6cdee224-4d18-482a-b084-e54fa1788095",
                            ConcurrencyStamp = "59ee6f8f-01b3-4921-bdac-d78275c8acd0",
                            Name = "Submitter",
                            NormalizedName = "SUBMITTER"
                        },
                        new
                        {
                            Id = "0d43b4f3-cf4c-497c-bc84-2f3e6351881e",
                            ConcurrencyStamp = "28a4ccdd-69db-4249-8674-4caee4b8cbf9",
                            Name = "Demo Admin",
                            NormalizedName = "DEMO_ADMIN"
                        },
                        new
                        {
                            Id = "461f41d5-9c6c-4d27-a11f-a9bd66c1da86",
                            ConcurrencyStamp = "5b9a569f-7038-42d4-a8b7-076b57d41550",
                            Name = " Demo Project Manager",
                            NormalizedName = "DEMO PROJECT MANAGER"
                        },
                        new
                        {
                            Id = "943bef04-4033-4206-b0d7-3c75517d552a",
                            ConcurrencyStamp = "e8a146e0-ff27-41cf-a4df-b6dc320b7f9f",
                            Name = "Demo Developer",
                            NormalizedName = "DEMO DEVELOPER"
                        },
                        new
                        {
                            Id = "ccf426f5-c344-40cb-ad59-ec468ef526b0",
                            ConcurrencyStamp = "9cee348a-0967-4bbb-bec0-f2c2a9194b7d",
                            Name = "Demo Submitter",
                            NormalizedName = "DEMO SUBMITTER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "21bbccc8-fc2a-4881-b746-ed9d90fbff9b",
                            RoleId = "ffd183c1-9d6f-4f65-8e4c-c08d5c6d3e65"
                        },
                        new
                        {
                            UserId = "c31a5e3d-a2ef-4065-a12c-2f9647f24070",
                            RoleId = "04614fbc-b0b7-4344-a2e9-8046742ac7cb"
                        },
                        new
                        {
                            UserId = "355daad8-1cb5-4caa-8538-e82508b5248a",
                            RoleId = "04614fbc-b0b7-4344-a2e9-8046742ac7cb"
                        },
                        new
                        {
                            UserId = "8c66bb8b-1fc7-491b-a4ef-d8de9ecc8e63",
                            RoleId = "6e8006e3-e50a-49be-94ea-03ab653713cc"
                        },
                        new
                        {
                            UserId = "68f84753-8203-45a0-ac1e-b2a06411d49a",
                            RoleId = "6e8006e3-e50a-49be-94ea-03ab653713cc"
                        },
                        new
                        {
                            UserId = "b964514f-fc0c-47f2-b16b-dfd7cbf8c167",
                            RoleId = "6cdee224-4d18-482a-b084-e54fa1788095"
                        },
                        new
                        {
                            UserId = "df656ced-7b29-4504-baeb-60d628c56739",
                            RoleId = "6cdee224-4d18-482a-b084-e54fa1788095"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BugTracker.Domain.Entities.Comment", b =>
                {
                    b.HasOne("BugTracker.Domain.Entities.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("BugTracker.Domain.Entities.ProjectTeamMember", b =>
                {
                    b.HasOne("BugTracker.Domain.Entities.Project", "Project")
                        .WithMany("ProjectTeamMembers")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BugTracker.Domain.Identity.ApplicationUser", "User")
                        .WithMany("ProjectTeamMembers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BugTracker.Domain.Entities.Ticket", b =>
                {
                    b.HasOne("BugTracker.Domain.Identity.ApplicationUser", null)
                        .WithMany("Tickets")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("BugTracker.Domain.Entities.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("BugTracker.Domain.Entities.TicketsTeamMembers", b =>
                {
                    b.HasOne("BugTracker.Domain.Entities.Ticket", "Ticket")
                        .WithMany("TicketsTeamMembers")
                        .HasForeignKey("TicketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BugTracker.Domain.Identity.ApplicationUser", "User")
                        .WithMany("TicketsTeamMembers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ticket");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BugTracker.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BugTracker.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BugTracker.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BugTracker.Domain.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BugTracker.Domain.Entities.Project", b =>
                {
                    b.Navigation("ProjectTeamMembers");
                });

            modelBuilder.Entity("BugTracker.Domain.Entities.Ticket", b =>
                {
                    b.Navigation("TicketsTeamMembers");
                });

            modelBuilder.Entity("BugTracker.Domain.Identity.ApplicationUser", b =>
                {
                    b.Navigation("ProjectTeamMembers");

                    b.Navigation("Tickets");

                    b.Navigation("TicketsTeamMembers");
                });
#pragma warning restore 612, 618
        }
    }
}
