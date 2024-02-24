﻿// <auto-generated />
using System;
using HealthTourist.Persistence.DatabaseContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HealthTourist.Persistence.Migrations
{
    [DbContext(typeof(HealthTouristDbContext))]
    partial class HealthTouristDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("HealthTourist.Domain.AboutUsPage.AboutUs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatorId")
                        .HasColumnType("text");

                    b.Property<DateTime>("DeletionDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ModificationDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ModifierId")
                        .HasColumnType("text");

                    b.Property<string>("RemoverId")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("AboutUs", "Main");
                });

            modelBuilder.Entity("HealthTourist.Domain.AboutUsPage.AboutUsAttachment", b =>
                {
                    b.Property<int>("AboutUsId")
                        .HasColumnType("integer");

                    b.Property<Guid>("AttachmentId")
                        .HasColumnType("uuid");

                    b.HasKey("AboutUsId", "AttachmentId");

                    b.HasIndex("AttachmentId");

                    b.ToTable("AboutUsAttachment", "Interface");
                });

            modelBuilder.Entity("HealthTourist.Domain.AboutUsPage.AboutUsOffice", b =>
                {
                    b.Property<int>("AboutUsId")
                        .HasColumnType("integer");

                    b.Property<int>("OfficeId")
                        .HasColumnType("integer");

                    b.HasKey("AboutUsId", "OfficeId");

                    b.HasIndex("OfficeId");

                    b.ToTable("AboutUsOffice", "Interface");
                });

            modelBuilder.Entity("HealthTourist.Domain.AboutUsPage.AboutUsTeamMember", b =>
                {
                    b.Property<int>("AboutUsId")
                        .HasColumnType("integer");

                    b.Property<int>("TeamMemberId")
                        .HasColumnType("integer");

                    b.HasKey("AboutUsId", "TeamMemberId");

                    b.HasIndex("TeamMemberId");

                    b.ToTable("AboutUsTeamMember", "Interface");
                });

            modelBuilder.Entity("HealthTourist.Domain.AboutUsPage.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatorId")
                        .HasColumnType("text");

                    b.Property<DateTime>("DeletionDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("FaxNumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ModificationDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ModifierId")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("PhoneNumber1")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<string>("PhoneNumber2")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<string>("PhoneNumber3")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<string>("RemoverId")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Office", "Main");
                });

            modelBuilder.Entity("HealthTourist.Domain.AboutUsPage.OfficeLocation", b =>
                {
                    b.Property<int>("OfficeId")
                        .HasColumnType("integer");

                    b.Property<Guid>("LocationId")
                        .HasColumnType("uuid");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OfficeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("OfficeId", "LocationId");

                    b.HasIndex("LocationId");

                    b.ToTable("OfficeLocation", "Interface");
                });

            modelBuilder.Entity("HealthTourist.Domain.AboutUsPage.TeamMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CareerPosition")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatorId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DeletionDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ModificationDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ModifierId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("PersonId")
                        .HasColumnType("bigint");

                    b.Property<int>("Prefix")
                        .HasColumnType("integer");

                    b.Property<string>("RemoverId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("TeamMember", "Main");
                });

            modelBuilder.Entity("HealthTourist.Domain.AboutUsPage.TeamMemberSocialMedia", b =>
                {
                    b.Property<int>("TeamMemberId")
                        .HasColumnType("integer");

                    b.Property<int>("SocialMedia")
                        .HasColumnType("integer");

                    b.HasKey("TeamMemberId", "SocialMedia");

                    b.ToTable("TeamMemberSocialMedia", "Interface");
                });

            modelBuilder.Entity("HealthTourist.Domain.AboutUsPage.TeamMemberState", b =>
                {
                    b.Property<int>("TeamMemberId")
                        .HasColumnType("integer");

                    b.Property<int>("StateId")
                        .HasColumnType("integer");

                    b.HasKey("TeamMemberId", "StateId");

                    b.HasIndex("StateId");

                    b.ToTable("TeamMemberState", "Interface");
                });

            modelBuilder.Entity("HealthTourist.Domain.Account.Person", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatorId")
                        .HasColumnType("text");

                    b.Property<DateTime>("DeletionDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("ModificationDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ModifierId")
                        .HasColumnType("text");

                    b.Property<string>("NationalCode")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<string>("RemoverId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Person", "Identity");
                });

            modelBuilder.Entity("HealthTourist.Domain.Account.PersonAttachment", b =>
                {
                    b.Property<long>("PersonId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("AttachmentId")
                        .HasColumnType("uuid");

                    b.Property<int>("ExtensionType")
                        .HasColumnType("integer");

                    b.HasKey("PersonId", "AttachmentId");

                    b.HasIndex("AttachmentId");

                    b.ToTable("PersonAttachment", "Interface");
                });

            modelBuilder.Entity("HealthTourist.Domain.Common.Attachment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatorId")
                        .HasColumnType("text");

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<DateTime>("DeletionDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ModificationDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ModifierId")
                        .HasColumnType("text");

                    b.Property<string>("RemoverId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Attachment", "dbo");
                });

            modelBuilder.Entity("HealthTourist.Domain.Common.Location", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatorId")
                        .HasColumnType("text");

                    b.Property<DateTime>("DeletionDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("boolean");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime>("ModificationDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ModifierId")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("RemoverId")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Location", "dbo");
                });

            modelBuilder.Entity("HealthTourist.Domain.Common.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatorId")
                        .HasColumnType("text");

                    b.Property<DateTime>("DeletionDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ModificationDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ModifierId")
                        .HasColumnType("text");

                    b.Property<int?>("ParentId")
                        .HasColumnType("integer");

                    b.Property<string>("RemoverId")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("State", "dbo");
                });

            modelBuilder.Entity("HealthTourist.Domain.AboutUsPage.AboutUsAttachment", b =>
                {
                    b.HasOne("HealthTourist.Domain.AboutUsPage.AboutUs", "AboutUs")
                        .WithMany("AboutUsAttachments")
                        .HasForeignKey("AboutUsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthTourist.Domain.Common.Attachment", "Attachment")
                        .WithMany("AboutUsAttachments")
                        .HasForeignKey("AttachmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("AboutUs");

                    b.Navigation("Attachment");
                });

            modelBuilder.Entity("HealthTourist.Domain.AboutUsPage.AboutUsOffice", b =>
                {
                    b.HasOne("HealthTourist.Domain.AboutUsPage.AboutUs", "AboutUs")
                        .WithMany("AboutUsOffices")
                        .HasForeignKey("AboutUsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthTourist.Domain.AboutUsPage.Office", "Office")
                        .WithMany("AboutUsOffices")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("AboutUs");

                    b.Navigation("Office");
                });

            modelBuilder.Entity("HealthTourist.Domain.AboutUsPage.AboutUsTeamMember", b =>
                {
                    b.HasOne("HealthTourist.Domain.AboutUsPage.AboutUs", "AboutUs")
                        .WithMany("AboutUsTeamMembers")
                        .HasForeignKey("AboutUsId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HealthTourist.Domain.AboutUsPage.TeamMember", "TeamMember")
                        .WithMany("AboutUsTeamMembers")
                        .HasForeignKey("TeamMemberId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("AboutUs");

                    b.Navigation("TeamMember");
                });

            modelBuilder.Entity("HealthTourist.Domain.AboutUsPage.OfficeLocation", b =>
                {
                    b.HasOne("HealthTourist.Domain.Common.Location", "Location")
                        .WithMany("OfficeLocations")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthTourist.Domain.AboutUsPage.Office", "Office")
                        .WithMany("OfficeLocations")
                        .HasForeignKey("OfficeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Office");
                });

            modelBuilder.Entity("HealthTourist.Domain.AboutUsPage.TeamMember", b =>
                {
                    b.HasOne("HealthTourist.Domain.Account.Person", "Person")
                        .WithOne("TeamMember")
                        .HasForeignKey("HealthTourist.Domain.AboutUsPage.TeamMember", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("HealthTourist.Domain.AboutUsPage.TeamMemberSocialMedia", b =>
                {
                    b.HasOne("HealthTourist.Domain.AboutUsPage.TeamMember", "TeamMember")
                        .WithMany("TeamMemberSocialMedias")
                        .HasForeignKey("TeamMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TeamMember");
                });

            modelBuilder.Entity("HealthTourist.Domain.AboutUsPage.TeamMemberState", b =>
                {
                    b.HasOne("HealthTourist.Domain.Common.State", "State")
                        .WithMany("TeamMemberStates")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthTourist.Domain.AboutUsPage.TeamMember", "TeamMember")
                        .WithMany("TeamMemberStates")
                        .HasForeignKey("TeamMemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");

                    b.Navigation("TeamMember");
                });

            modelBuilder.Entity("HealthTourist.Domain.Account.PersonAttachment", b =>
                {
                    b.HasOne("HealthTourist.Domain.Common.Attachment", "Attachment")
                        .WithMany("PersonAttachments")
                        .HasForeignKey("AttachmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthTourist.Domain.Account.Person", "Person")
                        .WithMany("PersonAttachments")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attachment");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("HealthTourist.Domain.Common.State", b =>
                {
                    b.HasOne("HealthTourist.Domain.Common.State", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("HealthTourist.Domain.AboutUsPage.AboutUs", b =>
                {
                    b.Navigation("AboutUsAttachments");

                    b.Navigation("AboutUsOffices");

                    b.Navigation("AboutUsTeamMembers");
                });

            modelBuilder.Entity("HealthTourist.Domain.AboutUsPage.Office", b =>
                {
                    b.Navigation("AboutUsOffices");

                    b.Navigation("OfficeLocations");
                });

            modelBuilder.Entity("HealthTourist.Domain.AboutUsPage.TeamMember", b =>
                {
                    b.Navigation("AboutUsTeamMembers");

                    b.Navigation("TeamMemberSocialMedias");

                    b.Navigation("TeamMemberStates");
                });

            modelBuilder.Entity("HealthTourist.Domain.Account.Person", b =>
                {
                    b.Navigation("PersonAttachments");

                    b.Navigation("TeamMember")
                        .IsRequired();
                });

            modelBuilder.Entity("HealthTourist.Domain.Common.Attachment", b =>
                {
                    b.Navigation("AboutUsAttachments");

                    b.Navigation("PersonAttachments");
                });

            modelBuilder.Entity("HealthTourist.Domain.Common.Location", b =>
                {
                    b.Navigation("OfficeLocations");
                });

            modelBuilder.Entity("HealthTourist.Domain.Common.State", b =>
                {
                    b.Navigation("TeamMemberStates");
                });
#pragma warning restore 612, 618
        }
    }
}
