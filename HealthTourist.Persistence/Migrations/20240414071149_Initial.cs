using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HealthTourist.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Main");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.EnsureSchema(
                name: "Interface");

            migrationBuilder.EnsureSchema(
                name: "Account");

            migrationBuilder.CreateTable(
                name: "AirLine",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirLine", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attachment",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Content = table.Column<byte[]>(type: "bytea", nullable: false),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Extension = table.Column<int>(type: "integer", nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CostDetails",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FaqType",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaqType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HospitalType",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HotelType",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                schema: "Account",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    PhoneNumber = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    IsPatient = table.Column<bool>(type: "boolean", nullable: false),
                    IsGuest = table.Column<bool>(type: "boolean", nullable: false),
                    IsDoctor = table.Column<bool>(type: "boolean", nullable: false),
                    IsAdmin = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TreatmentType",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreatmentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "State",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CountryId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                    table.ForeignKey(
                        name: "FK_State_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "dbo",
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Faq",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FaqTypeId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    Priority = table.Column<int>(type: "integer", nullable: false),
                    IsFirstPage = table.Column<bool>(type: "boolean", nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faq", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faq_FaqType_FaqTypeId",
                        column: x => x.FaqTypeId,
                        principalSchema: "Main",
                        principalTable: "FaqType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FaqTypeAttachment",
                schema: "Interface",
                columns: table => new
                {
                    FaqTypeId = table.Column<int>(type: "integer", nullable: false),
                    AttachmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    IsSelected = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaqTypeAttachment", x => new { x.FaqTypeId, x.AttachmentId });
                    table.ForeignKey(
                        name: "FK_FaqTypeAttachment_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalSchema: "dbo",
                        principalTable: "Attachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FaqTypeAttachment_FaqType_FaqTypeId",
                        column: x => x.FaqTypeId,
                        principalSchema: "Main",
                        principalTable: "FaqType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotelRank",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HotelTypeId = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelRank", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HotelRank_HotelType_HotelTypeId",
                        column: x => x.HotelTypeId,
                        principalSchema: "Main",
                        principalTable: "HotelType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Guest",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guest_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Account",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    Height = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    Weight = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patient_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Account",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Treatment",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TreatmentTypeId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Treatment_TreatmentType_TreatmentTypeId",
                        column: x => x.TreatmentTypeId,
                        principalSchema: "Main",
                        principalTable: "TreatmentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TreatmentTypeAttachment",
                schema: "Interface",
                columns: table => new
                {
                    TreatmentTypeId = table.Column<int>(type: "integer", nullable: false),
                    AttachmentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreatmentTypeAttachment", x => new { x.TreatmentTypeId, x.AttachmentId });
                    table.ForeignKey(
                        name: "FK_TreatmentTypeAttachment_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalSchema: "dbo",
                        principalTable: "Attachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TreatmentTypeAttachment_TreatmentType_TreatmentTypeId",
                        column: x => x.TreatmentTypeId,
                        principalSchema: "Main",
                        principalTable: "TreatmentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "City",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StateId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_State_StateId",
                        column: x => x.StateId,
                        principalSchema: "dbo",
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Triage",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TriageNo = table.Column<Guid>(type: "uuid", nullable: false),
                    PatientId = table.Column<long>(type: "bigint", nullable: false),
                    TreatmentId = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Triage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Triage_Patient_PatientId",
                        column: x => x.PatientId,
                        principalSchema: "Main",
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Triage_Treatment_TreatmentId",
                        column: x => x.TreatmentId,
                        principalSchema: "Main",
                        principalTable: "Treatment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CityAttachment",
                schema: "Interface",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    AttachmentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityAttachment", x => new { x.CityId, x.AttachmentId });
                    table.ForeignKey(
                        name: "FK_CityAttachment_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalSchema: "dbo",
                        principalTable: "Attachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityAttachment_City_CityId",
                        column: x => x.CityId,
                        principalSchema: "dbo",
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hospital",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HospitalTypeId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    Address = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Lat = table.Column<long>(type: "bigint", nullable: false),
                    Long = table.Column<long>(type: "bigint", nullable: false),
                    PostalCode = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    PhoneNumber1 = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    PhoneNumber2 = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    PhoneNumber3 = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    NumberOfBeds = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    EstablishmentDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CityId1 = table.Column<int>(type: "integer", nullable: true),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospital", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hospital_City_CityId",
                        column: x => x.CityId,
                        principalSchema: "dbo",
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hospital_City_CityId1",
                        column: x => x.CityId1,
                        principalSchema: "dbo",
                        principalTable: "City",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Hospital_HospitalType_HospitalTypeId",
                        column: x => x.HospitalTypeId,
                        principalSchema: "Main",
                        principalTable: "HospitalType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hotel",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HotelRankId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    Address = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Lat = table.Column<long>(type: "bigint", nullable: false),
                    Long = table.Column<long>(type: "bigint", nullable: false),
                    PostalCode = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    PhoneNumber1 = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    PhoneNumber2 = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    PhoneNumber3 = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    Website = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    CheckInTime = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    CheckOutTime = table.Column<TimeOnly>(type: "time without time zone", nullable: false),
                    NumberOfRooms = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    EstablishmentDate = table.Column<DateOnly>(type: "date", nullable: false),
                    CityId1 = table.Column<int>(type: "integer", nullable: true),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hotel_City_CityId",
                        column: x => x.CityId,
                        principalSchema: "dbo",
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hotel_City_CityId1",
                        column: x => x.CityId1,
                        principalSchema: "dbo",
                        principalTable: "City",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Hotel_HotelRank_HotelRankId",
                        column: x => x.HotelRankId,
                        principalSchema: "Main",
                        principalTable: "HotelRank",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Office",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Lat = table.Column<long>(type: "bigint", nullable: false),
                    Long = table.Column<long>(type: "bigint", nullable: false),
                    CountryId = table.Column<int>(type: "integer", nullable: false),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    PostalCode = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    PhoneNumber1 = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    PhoneNumber2 = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    PhoneNumber3 = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    OwnerCommission = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    PresentedCommission = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    CityId1 = table.Column<int>(type: "integer", nullable: true),
                    CountryId1 = table.Column<int>(type: "integer", nullable: true),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Office", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Office_City_CityId",
                        column: x => x.CityId,
                        principalSchema: "dbo",
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Office_City_CityId1",
                        column: x => x.CityId1,
                        principalSchema: "dbo",
                        principalTable: "City",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Office_Country_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "dbo",
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Office_Country_CountryId1",
                        column: x => x.CountryId1,
                        principalSchema: "dbo",
                        principalTable: "Country",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sightseen",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Lat = table.Column<long>(type: "bigint", nullable: false),
                    Long = table.Column<long>(type: "bigint", nullable: false),
                    CityId1 = table.Column<int>(type: "integer", nullable: true),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sightseen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sightseen_City_CityId",
                        column: x => x.CityId,
                        principalSchema: "dbo",
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sightseen_City_CityId1",
                        column: x => x.CityId1,
                        principalSchema: "dbo",
                        principalTable: "City",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TriageAttachment",
                schema: "Interface",
                columns: table => new
                {
                    TriageId = table.Column<Guid>(type: "uuid", nullable: false),
                    AttachmentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TriageAttachment", x => new { x.TriageId, x.AttachmentId });
                    table.ForeignKey(
                        name: "FK_TriageAttachment_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalSchema: "dbo",
                        principalTable: "Attachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TriageAttachment_Triage_TriageId",
                        column: x => x.TriageId,
                        principalSchema: "Main",
                        principalTable: "Triage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    HospitalId = table.Column<int>(type: "integer", nullable: false),
                    TreatmentId = table.Column<int>(type: "integer", nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctor_Hospital_HospitalId",
                        column: x => x.HospitalId,
                        principalSchema: "Main",
                        principalTable: "Hospital",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doctor_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Account",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doctor_Treatment_TreatmentId",
                        column: x => x.TreatmentId,
                        principalSchema: "Main",
                        principalTable: "Treatment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HospitalAttachment",
                schema: "Interface",
                columns: table => new
                {
                    HospitalId = table.Column<int>(type: "integer", nullable: false),
                    AttachmentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalAttachment", x => new { x.HospitalId, x.AttachmentId });
                    table.ForeignKey(
                        name: "FK_HospitalAttachment_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalSchema: "dbo",
                        principalTable: "Attachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalAttachment_Hospital_HospitalId",
                        column: x => x.HospitalId,
                        principalSchema: "Main",
                        principalTable: "Hospital",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HospitalGallery",
                schema: "Interface",
                columns: table => new
                {
                    HospitalId = table.Column<int>(type: "integer", nullable: false),
                    AttachmentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalGallery", x => new { x.HospitalId, x.AttachmentId });
                    table.ForeignKey(
                        name: "FK_HospitalGallery_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalSchema: "dbo",
                        principalTable: "Attachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalGallery_Hospital_HospitalId",
                        column: x => x.HospitalId,
                        principalSchema: "Main",
                        principalTable: "Hospital",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HospitalTag",
                schema: "Interface",
                columns: table => new
                {
                    HospitalId = table.Column<int>(type: "integer", nullable: false),
                    TagId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalTag", x => new { x.HospitalId, x.TagId });
                    table.ForeignKey(
                        name: "FK_HospitalTag_Hospital_HospitalId",
                        column: x => x.HospitalId,
                        principalSchema: "Main",
                        principalTable: "Hospital",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalTag_Tag_TagId",
                        column: x => x.TagId,
                        principalSchema: "Main",
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotelAttachment",
                schema: "Interface",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "integer", nullable: false),
                    AttachmentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelAttachment", x => new { x.HotelId, x.AttachmentId });
                    table.ForeignKey(
                        name: "FK_HotelAttachment_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalSchema: "dbo",
                        principalTable: "Attachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HotelAttachment_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalSchema: "Main",
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotelGallery",
                schema: "Interface",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "integer", nullable: false),
                    AttachmentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelGallery", x => new { x.HotelId, x.AttachmentId });
                    table.ForeignKey(
                        name: "FK_HotelGallery_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalSchema: "dbo",
                        principalTable: "Attachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HotelGallery_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalSchema: "Main",
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HotelTag",
                schema: "Interface",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "integer", nullable: false),
                    TagId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelTag", x => new { x.HotelId, x.TagId });
                    table.ForeignKey(
                        name: "FK_HotelTag_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalSchema: "Main",
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HotelTag_Tag_TagId",
                        column: x => x.TagId,
                        principalSchema: "Main",
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Travel",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TriageNo = table.Column<Guid>(type: "uuid", nullable: false),
                    PatientId = table.Column<long>(type: "bigint", nullable: false),
                    HotelId = table.Column<int>(type: "integer", nullable: false),
                    AirLineId = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Cost = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Travel_AirLine_AirLineId",
                        column: x => x.AirLineId,
                        principalSchema: "Main",
                        principalTable: "AirLine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Travel_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalSchema: "Main",
                        principalTable: "Hotel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Travel_Patient_PatientId",
                        column: x => x.PatientId,
                        principalSchema: "Main",
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OfficeAttachment",
                schema: "Interface",
                columns: table => new
                {
                    OfficeId = table.Column<int>(type: "integer", nullable: false),
                    AttachmentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeAttachment", x => new { x.OfficeId, x.AttachmentId });
                    table.ForeignKey(
                        name: "FK_OfficeAttachment_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalSchema: "dbo",
                        principalTable: "Attachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OfficeAttachment_Office_OfficeId",
                        column: x => x.OfficeId,
                        principalSchema: "Main",
                        principalTable: "Office",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OfficeManager",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    OfficeId = table.Column<int>(type: "integer", nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeManager", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfficeManager_Office_OfficeId",
                        column: x => x.OfficeId,
                        principalSchema: "Main",
                        principalTable: "Office",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OfficeManager_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Account",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SightseenAttachment",
                schema: "Interface",
                columns: table => new
                {
                    SightseenId = table.Column<int>(type: "integer", nullable: false),
                    AttachmentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SightseenAttachment", x => new { x.SightseenId, x.AttachmentId });
                    table.ForeignKey(
                        name: "FK_SightseenAttachment_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalSchema: "dbo",
                        principalTable: "Attachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SightseenAttachment_Sightseen_SightseenId",
                        column: x => x.SightseenId,
                        principalSchema: "Main",
                        principalTable: "Sightseen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SightseenCategory",
                schema: "Interface",
                columns: table => new
                {
                    SightseenId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SightseenCategory", x => new { x.SightseenId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_SightseenCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "Main",
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SightseenCategory_Sightseen_SightseenId",
                        column: x => x.SightseenId,
                        principalSchema: "Main",
                        principalTable: "Sightseen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorAttachment",
                schema: "Interface",
                columns: table => new
                {
                    DoctorId = table.Column<long>(type: "bigint", nullable: false),
                    AttachmentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorAttachment", x => new { x.DoctorId, x.AttachmentId });
                    table.ForeignKey(
                        name: "FK_DoctorAttachment_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalSchema: "dbo",
                        principalTable: "Attachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorAttachment_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalSchema: "Main",
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorSocialMedia",
                schema: "Interface",
                columns: table => new
                {
                    DoctorId = table.Column<long>(type: "bigint", nullable: false),
                    SocialMedia = table.Column<int>(type: "integer", nullable: false),
                    Link = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorSocialMedia", x => x.DoctorId);
                    table.ForeignKey(
                        name: "FK_DoctorSocialMedia_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalSchema: "Main",
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Health",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TriageNo = table.Column<Guid>(type: "uuid", nullable: false),
                    HospitalId = table.Column<int>(type: "integer", nullable: false),
                    DoctorId = table.Column<long>(type: "bigint", nullable: false),
                    Cost = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    DoctorId1 = table.Column<long>(type: "bigint", nullable: true),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Health", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Health_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalSchema: "Main",
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Health_Doctor_DoctorId1",
                        column: x => x.DoctorId1,
                        principalSchema: "Main",
                        principalTable: "Doctor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Health_Hospital_HospitalId",
                        column: x => x.HospitalId,
                        principalSchema: "Main",
                        principalTable: "Hospital",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamMember",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    DoctorId = table.Column<long>(type: "bigint", nullable: false),
                    TreatmentId = table.Column<int>(type: "integer", nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMember", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamMember_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalSchema: "Main",
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamMember_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Account",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamMember_Treatment_TreatmentId",
                        column: x => x.TreatmentId,
                        principalSchema: "Main",
                        principalTable: "Treatment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TravelAttachment",
                schema: "Interface",
                columns: table => new
                {
                    TravelId = table.Column<Guid>(type: "uuid", nullable: false),
                    AttachmentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelAttachment", x => new { x.TravelId, x.AttachmentId });
                    table.ForeignKey(
                        name: "FK_TravelAttachment_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalSchema: "dbo",
                        principalTable: "Attachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelAttachment_Travel_TravelId",
                        column: x => x.TravelId,
                        principalSchema: "Main",
                        principalTable: "Travel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TravelCost",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TravelId = table.Column<Guid>(type: "uuid", nullable: false),
                    CostDetailsId = table.Column<int>(type: "integer", nullable: false),
                    Cost = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    CostDetailsId1 = table.Column<int>(type: "integer", nullable: true),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelCost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TravelCost_CostDetails_CostDetailsId",
                        column: x => x.CostDetailsId,
                        principalSchema: "Main",
                        principalTable: "CostDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelCost_CostDetails_CostDetailsId1",
                        column: x => x.CostDetailsId1,
                        principalSchema: "Main",
                        principalTable: "CostDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TravelCost_Travel_TravelId",
                        column: x => x.TravelId,
                        principalSchema: "Main",
                        principalTable: "Travel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TravelGuest",
                schema: "Interface",
                columns: table => new
                {
                    TravelId = table.Column<Guid>(type: "uuid", nullable: false),
                    GuestId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelGuest", x => new { x.TravelId, x.GuestId });
                    table.ForeignKey(
                        name: "FK_TravelGuest_Guest_GuestId",
                        column: x => x.GuestId,
                        principalSchema: "Main",
                        principalTable: "Guest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravelGuest_Travel_TravelId",
                        column: x => x.TravelId,
                        principalSchema: "Main",
                        principalTable: "Travel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthAttachment",
                schema: "Interface",
                columns: table => new
                {
                    HealthId = table.Column<Guid>(type: "uuid", nullable: false),
                    AttachmentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthAttachment", x => new { x.HealthId, x.AttachmentId });
                    table.ForeignKey(
                        name: "FK_HealthAttachment_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalSchema: "dbo",
                        principalTable: "Attachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HealthAttachment_Health_HealthId",
                        column: x => x.HealthId,
                        principalSchema: "Main",
                        principalTable: "Health",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthCost",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HealthId = table.Column<Guid>(type: "uuid", nullable: false),
                    CostDetailsId = table.Column<int>(type: "integer", nullable: false),
                    Cost = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    CostDetailsId1 = table.Column<int>(type: "integer", nullable: true),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthCost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthCost_CostDetails_CostDetailsId",
                        column: x => x.CostDetailsId,
                        principalSchema: "Main",
                        principalTable: "CostDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HealthCost_CostDetails_CostDetailsId1",
                        column: x => x.CostDetailsId1,
                        principalSchema: "Main",
                        principalTable: "CostDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HealthCost_Health_HealthId",
                        column: x => x.HealthId,
                        principalSchema: "Main",
                        principalTable: "Health",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    HealthId = table.Column<Guid>(type: "uuid", nullable: false),
                    TravelId = table.Column<Guid>(type: "uuid", nullable: false),
                    TotalPrice = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoice_Health_HealthId",
                        column: x => x.HealthId,
                        principalSchema: "Main",
                        principalTable: "Health",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Invoice_Travel_TravelId",
                        column: x => x.TravelId,
                        principalSchema: "Main",
                        principalTable: "Travel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceCost",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    InvoiceId = table.Column<long>(type: "bigint", nullable: false),
                    CostDetailsId = table.Column<int>(type: "integer", nullable: false),
                    Cost = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    CostDetailsId1 = table.Column<int>(type: "integer", nullable: true),
                    CreatorId = table.Column<string>(type: "text", nullable: false),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: false),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: false),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceCost", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InvoiceCost_CostDetails_CostDetailsId",
                        column: x => x.CostDetailsId,
                        principalSchema: "Main",
                        principalTable: "CostDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceCost_CostDetails_CostDetailsId1",
                        column: x => x.CostDetailsId1,
                        principalSchema: "Main",
                        principalTable: "CostDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InvoiceCost_Invoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalSchema: "Main",
                        principalTable: "Invoice",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AirLine_Name",
                schema: "Main",
                table: "AirLine",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_AirLine_Title",
                schema: "Main",
                table: "AirLine",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_Attachment_Name",
                schema: "dbo",
                table: "Attachment",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Category_Name",
                schema: "Main",
                table: "Category",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Category_Title",
                schema: "Main",
                table: "Category",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_City_Name",
                schema: "dbo",
                table: "City",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_City_StateId",
                schema: "dbo",
                table: "City",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_CityAttachment_AttachmentId",
                schema: "Interface",
                table: "CityAttachment",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_CostDetails_Name",
                schema: "Main",
                table: "CostDetails",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_CostDetails_Title",
                schema: "Main",
                table: "CostDetails",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_Country_Code",
                schema: "dbo",
                table: "Country",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_Country_Name",
                schema: "dbo",
                table: "Country",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Country_Title",
                schema: "dbo",
                table: "Country",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_HospitalId",
                schema: "Main",
                table: "Doctor",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_PersonId",
                schema: "Main",
                table: "Doctor",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_TreatmentId",
                schema: "Main",
                table: "Doctor",
                column: "TreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorAttachment_AttachmentId",
                schema: "Interface",
                table: "DoctorAttachment",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Faq_FaqTypeId",
                schema: "Main",
                table: "Faq",
                column: "FaqTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Faq_Title",
                schema: "Main",
                table: "Faq",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_FaqType_Name",
                schema: "Main",
                table: "FaqType",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_FaqType_Title",
                schema: "Main",
                table: "FaqType",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_FaqTypeAttachment_AttachmentId",
                schema: "Interface",
                table: "FaqTypeAttachment",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Guest_PersonId",
                schema: "Main",
                table: "Guest",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Health_DoctorId",
                schema: "Main",
                table: "Health",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Health_DoctorId1",
                schema: "Main",
                table: "Health",
                column: "DoctorId1");

            migrationBuilder.CreateIndex(
                name: "IX_Health_HospitalId",
                schema: "Main",
                table: "Health",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Health_TriageNo",
                schema: "Main",
                table: "Health",
                column: "TriageNo");

            migrationBuilder.CreateIndex(
                name: "IX_HealthAttachment_AttachmentId",
                schema: "Interface",
                table: "HealthAttachment",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCost_CostDetailsId",
                schema: "Main",
                table: "HealthCost",
                column: "CostDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCost_CostDetailsId1",
                schema: "Main",
                table: "HealthCost",
                column: "CostDetailsId1");

            migrationBuilder.CreateIndex(
                name: "IX_HealthCost_HealthId",
                schema: "Main",
                table: "HealthCost",
                column: "HealthId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospital_Address",
                schema: "Main",
                table: "Hospital",
                column: "Address");

            migrationBuilder.CreateIndex(
                name: "IX_Hospital_CityId",
                schema: "Main",
                table: "Hospital",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospital_CityId1",
                schema: "Main",
                table: "Hospital",
                column: "CityId1");

            migrationBuilder.CreateIndex(
                name: "IX_Hospital_HospitalTypeId",
                schema: "Main",
                table: "Hospital",
                column: "HospitalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospital_PhoneNumber1",
                schema: "Main",
                table: "Hospital",
                column: "PhoneNumber1");

            migrationBuilder.CreateIndex(
                name: "IX_Hospital_PhoneNumber2",
                schema: "Main",
                table: "Hospital",
                column: "PhoneNumber2");

            migrationBuilder.CreateIndex(
                name: "IX_Hospital_PhoneNumber3",
                schema: "Main",
                table: "Hospital",
                column: "PhoneNumber3");

            migrationBuilder.CreateIndex(
                name: "IX_Hospital_Title",
                schema: "Main",
                table: "Hospital",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalAttachment_AttachmentId",
                schema: "Interface",
                table: "HospitalAttachment",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalGallery_AttachmentId",
                schema: "Interface",
                table: "HospitalGallery",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalTag_TagId",
                schema: "Interface",
                table: "HospitalTag",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalType_Name",
                schema: "Main",
                table: "HospitalType",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalType_Title",
                schema: "Main",
                table: "HospitalType",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_Address",
                schema: "Main",
                table: "Hotel",
                column: "Address");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_CityId",
                schema: "Main",
                table: "Hotel",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_CityId1",
                schema: "Main",
                table: "Hotel",
                column: "CityId1");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_Email",
                schema: "Main",
                table: "Hotel",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_HotelRankId",
                schema: "Main",
                table: "Hotel",
                column: "HotelRankId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_Name",
                schema: "Main",
                table: "Hotel",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_PhoneNumber1",
                schema: "Main",
                table: "Hotel",
                column: "PhoneNumber1");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_PhoneNumber2",
                schema: "Main",
                table: "Hotel",
                column: "PhoneNumber2");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_PhoneNumber3",
                schema: "Main",
                table: "Hotel",
                column: "PhoneNumber3");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_PostalCode",
                schema: "Main",
                table: "Hotel",
                column: "PostalCode");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_Title",
                schema: "Main",
                table: "Hotel",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_Website",
                schema: "Main",
                table: "Hotel",
                column: "Website");

            migrationBuilder.CreateIndex(
                name: "IX_HotelAttachment_AttachmentId",
                schema: "Interface",
                table: "HotelAttachment",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelGallery_AttachmentId",
                schema: "Interface",
                table: "HotelGallery",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelRank_HotelTypeId",
                schema: "Main",
                table: "HotelRank",
                column: "HotelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelTag_TagId",
                schema: "Interface",
                table: "HotelTag",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_HotelType_Name",
                schema: "Main",
                table: "HotelType",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_HotelType_Title",
                schema: "Main",
                table: "HotelType",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_HealthId",
                schema: "Main",
                table: "Invoice",
                column: "HealthId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_TravelId",
                schema: "Main",
                table: "Invoice",
                column: "TravelId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCost_CostDetailsId",
                schema: "Main",
                table: "InvoiceCost",
                column: "CostDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCost_CostDetailsId1",
                schema: "Main",
                table: "InvoiceCost",
                column: "CostDetailsId1");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCost_InvoiceId",
                schema: "Main",
                table: "InvoiceCost",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Office_Address",
                schema: "Main",
                table: "Office",
                column: "Address");

            migrationBuilder.CreateIndex(
                name: "IX_Office_CityId",
                schema: "Main",
                table: "Office",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Office_CityId1",
                schema: "Main",
                table: "Office",
                column: "CityId1");

            migrationBuilder.CreateIndex(
                name: "IX_Office_CountryId",
                schema: "Main",
                table: "Office",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Office_CountryId1",
                schema: "Main",
                table: "Office",
                column: "CountryId1");

            migrationBuilder.CreateIndex(
                name: "IX_Office_PhoneNumber1",
                schema: "Main",
                table: "Office",
                column: "PhoneNumber1");

            migrationBuilder.CreateIndex(
                name: "IX_Office_PhoneNumber2",
                schema: "Main",
                table: "Office",
                column: "PhoneNumber2");

            migrationBuilder.CreateIndex(
                name: "IX_Office_PhoneNumber3",
                schema: "Main",
                table: "Office",
                column: "PhoneNumber3");

            migrationBuilder.CreateIndex(
                name: "IX_Office_Title",
                schema: "Main",
                table: "Office",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_OfficeAttachment_AttachmentId",
                schema: "Interface",
                table: "OfficeAttachment",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_OfficeManager_OfficeId",
                schema: "Main",
                table: "OfficeManager",
                column: "OfficeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OfficeManager_PersonId",
                schema: "Main",
                table: "OfficeManager",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patient_PersonId",
                schema: "Main",
                table: "Patient",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Person_Address",
                schema: "Account",
                table: "Person",
                column: "Address");

            migrationBuilder.CreateIndex(
                name: "IX_Person_Email",
                schema: "Account",
                table: "Person",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_Person_FirstName",
                schema: "Account",
                table: "Person",
                column: "FirstName");

            migrationBuilder.CreateIndex(
                name: "IX_Person_LastName",
                schema: "Account",
                table: "Person",
                column: "LastName");

            migrationBuilder.CreateIndex(
                name: "IX_Person_PhoneNumber",
                schema: "Account",
                table: "Person",
                column: "PhoneNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Sightseen_CityId",
                schema: "Main",
                table: "Sightseen",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Sightseen_CityId1",
                schema: "Main",
                table: "Sightseen",
                column: "CityId1");

            migrationBuilder.CreateIndex(
                name: "IX_Sightseen_Name",
                schema: "Main",
                table: "Sightseen",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Sightseen_Title",
                schema: "Main",
                table: "Sightseen",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_SightseenAttachment_AttachmentId",
                schema: "Interface",
                table: "SightseenAttachment",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_SightseenCategory_CategoryId",
                schema: "Interface",
                table: "SightseenCategory",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_State_CountryId",
                schema: "dbo",
                table: "State",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_State_Name",
                schema: "dbo",
                table: "State",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_State_Title",
                schema: "dbo",
                table: "State",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMember_DoctorId",
                schema: "Main",
                table: "TeamMember",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMember_PersonId",
                schema: "Main",
                table: "TeamMember",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeamMember_TreatmentId",
                schema: "Main",
                table: "TeamMember",
                column: "TreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Travel_AirLineId",
                schema: "Main",
                table: "Travel",
                column: "AirLineId");

            migrationBuilder.CreateIndex(
                name: "IX_Travel_HotelId",
                schema: "Main",
                table: "Travel",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Travel_PatientId",
                schema: "Main",
                table: "Travel",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelAttachment_AttachmentId",
                schema: "Interface",
                table: "TravelAttachment",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelCost_CostDetailsId",
                schema: "Main",
                table: "TravelCost",
                column: "CostDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelCost_CostDetailsId1",
                schema: "Main",
                table: "TravelCost",
                column: "CostDetailsId1");

            migrationBuilder.CreateIndex(
                name: "IX_TravelCost_TravelId",
                schema: "Main",
                table: "TravelCost",
                column: "TravelId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelGuest_GuestId",
                schema: "Interface",
                table: "TravelGuest",
                column: "GuestId");

            migrationBuilder.CreateIndex(
                name: "IX_Treatment_Title",
                schema: "Main",
                table: "Treatment",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_Treatment_TreatmentTypeId",
                schema: "Main",
                table: "Treatment",
                column: "TreatmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentType_Name",
                schema: "Main",
                table: "TreatmentType",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentType_Title",
                schema: "Main",
                table: "TreatmentType",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_TreatmentTypeAttachment_AttachmentId",
                schema: "Interface",
                table: "TreatmentTypeAttachment",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Triage_PatientId",
                schema: "Main",
                table: "Triage",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_Triage_TreatmentId",
                schema: "Main",
                table: "Triage",
                column: "TreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_TriageAttachment_AttachmentId",
                schema: "Interface",
                table: "TriageAttachment",
                column: "AttachmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CityAttachment",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "DoctorAttachment",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "DoctorSocialMedia",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "Faq",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "FaqTypeAttachment",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "HealthAttachment",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "HealthCost",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "HospitalAttachment",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "HospitalGallery",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "HospitalTag",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "HotelAttachment",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "HotelGallery",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "HotelTag",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "InvoiceCost",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "OfficeAttachment",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "OfficeManager",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "SightseenAttachment",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "SightseenCategory",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "TeamMember",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "TravelAttachment",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "TravelCost",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "TravelGuest",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "TreatmentTypeAttachment",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "TriageAttachment",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "FaqType",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "Tag",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "Invoice",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "Office",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "Category",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "Sightseen",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "CostDetails",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "Guest",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "Attachment",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Triage",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "Health",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "Travel",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "Doctor",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "AirLine",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "Hotel",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "Patient",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "Hospital",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "Treatment",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "HotelRank",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "Person",
                schema: "Account");

            migrationBuilder.DropTable(
                name: "City",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "HospitalType",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "TreatmentType",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "HotelType",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "State",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Country",
                schema: "dbo");
        }
    }
}
