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
                name: "Interface");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.EnsureSchema(
                name: "Identity");

            migrationBuilder.CreateTable(
                name: "Attachment",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Data = table.Column<byte[]>(type: "bytea", nullable: false),
                    FileExtension = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: true),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: true),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Latitude = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Longitude = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: true),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: true),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Office",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    PhoneNumber1 = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    PhoneNumber2 = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    PhoneNumber3 = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    FaxNumber = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    PostalCode = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    CreatorId = table.Column<string>(type: "text", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: true),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: true),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Office", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                schema: "Identity",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NationalCode = table.Column<string>(type: "character varying(12)", maxLength: 12, nullable: false),
                    FirstName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    PhoneNumber = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    Email = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "text", nullable: true),
                    CreatorId = table.Column<string>(type: "text", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: true),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: true),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "State",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ParentId = table.Column<int>(type: "integer", nullable: true),
                    CreatorId = table.Column<string>(type: "text", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: true),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: true),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                    table.ForeignKey(
                        name: "FK_State_State_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "dbo",
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AboutUs",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    OfficeId = table.Column<int>(type: "integer", nullable: true),
                    CreatorId = table.Column<string>(type: "text", nullable: true),
                    CreationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifierId = table.Column<string>(type: "text", nullable: true),
                    ModificationDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RemoverId = table.Column<string>(type: "text", nullable: true),
                    DeletionDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    IsDisabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutUs_Office_OfficeId",
                        column: x => x.OfficeId,
                        principalSchema: "Main",
                        principalTable: "Office",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OfficeLocation",
                schema: "Interface",
                columns: table => new
                {
                    OfficeId = table.Column<int>(type: "integer", nullable: false),
                    LocationId = table.Column<Guid>(type: "uuid", nullable: false),
                    OfficeName = table.Column<string>(type: "text", nullable: false),
                    LocationName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeLocation", x => new { x.OfficeId, x.LocationId });
                    table.ForeignKey(
                        name: "FK_OfficeLocation_Location_LocationId",
                        column: x => x.LocationId,
                        principalSchema: "dbo",
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OfficeLocation_Office_OfficeId",
                        column: x => x.OfficeId,
                        principalSchema: "Main",
                        principalTable: "Office",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonAttachment",
                schema: "Interface",
                columns: table => new
                {
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    AttachmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    ExtensionType = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonAttachment", x => new { x.PersonId, x.AttachmentId });
                    table.ForeignKey(
                        name: "FK_PersonAttachment_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalSchema: "dbo",
                        principalTable: "Attachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonAttachment_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Identity",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamMember",
                schema: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    CareerPosition = table.Column<int>(type: "integer", nullable: false),
                    Prefix = table.Column<int>(type: "integer", nullable: false),
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
                        name: "FK_TeamMember_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "Identity",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AboutUsAttachment",
                schema: "Interface",
                columns: table => new
                {
                    AboutUsId = table.Column<int>(type: "integer", nullable: false),
                    AttachmentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUsAttachment", x => new { x.AboutUsId, x.AttachmentId });
                    table.ForeignKey(
                        name: "FK_AboutUsAttachment_AboutUs_AboutUsId",
                        column: x => x.AboutUsId,
                        principalSchema: "Main",
                        principalTable: "AboutUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AboutUsAttachment_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalSchema: "dbo",
                        principalTable: "Attachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AboutUsOffice",
                schema: "Interface",
                columns: table => new
                {
                    AboutUsId = table.Column<int>(type: "integer", nullable: false),
                    OfficeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUsOffice", x => new { x.AboutUsId, x.OfficeId });
                    table.ForeignKey(
                        name: "FK_AboutUsOffice_AboutUs_AboutUsId",
                        column: x => x.AboutUsId,
                        principalSchema: "Main",
                        principalTable: "AboutUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AboutUsOffice_Office_OfficeId",
                        column: x => x.OfficeId,
                        principalSchema: "Main",
                        principalTable: "Office",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AboutUsTeamMember",
                schema: "Interface",
                columns: table => new
                {
                    AboutUsId = table.Column<int>(type: "integer", nullable: false),
                    TeamMemberId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUsTeamMember", x => new { x.AboutUsId, x.TeamMemberId });
                    table.ForeignKey(
                        name: "FK_AboutUsTeamMember_AboutUs_AboutUsId",
                        column: x => x.AboutUsId,
                        principalSchema: "Main",
                        principalTable: "AboutUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AboutUsTeamMember_TeamMember_TeamMemberId",
                        column: x => x.TeamMemberId,
                        principalSchema: "Main",
                        principalTable: "TeamMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamMemberSocialMedia",
                schema: "Interface",
                columns: table => new
                {
                    TeamMemberId = table.Column<int>(type: "integer", nullable: false),
                    SocialMedia = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMemberSocialMedia", x => new { x.TeamMemberId, x.SocialMedia });
                    table.ForeignKey(
                        name: "FK_TeamMemberSocialMedia_TeamMember_TeamMemberId",
                        column: x => x.TeamMemberId,
                        principalSchema: "Main",
                        principalTable: "TeamMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeamMemberState",
                schema: "Interface",
                columns: table => new
                {
                    TeamMemberId = table.Column<int>(type: "integer", nullable: false),
                    StateId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMemberState", x => new { x.TeamMemberId, x.StateId });
                    table.ForeignKey(
                        name: "FK_TeamMemberState_State_StateId",
                        column: x => x.StateId,
                        principalSchema: "dbo",
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamMemberState_TeamMember_TeamMemberId",
                        column: x => x.TeamMemberId,
                        principalSchema: "Main",
                        principalTable: "TeamMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutUs_OfficeId",
                schema: "Main",
                table: "AboutUs",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutUsAttachment_AttachmentId",
                schema: "Interface",
                table: "AboutUsAttachment",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutUsOffice_OfficeId",
                schema: "Interface",
                table: "AboutUsOffice",
                column: "OfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutUsTeamMember_TeamMemberId",
                schema: "Interface",
                table: "AboutUsTeamMember",
                column: "TeamMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_OfficeLocation_LocationId",
                schema: "Interface",
                table: "OfficeLocation",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonAttachment_AttachmentId",
                schema: "Interface",
                table: "PersonAttachment",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_State_ParentId",
                schema: "dbo",
                table: "State",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMember_PersonId",
                schema: "Main",
                table: "TeamMember",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeamMemberState_StateId",
                schema: "Interface",
                table: "TeamMemberState",
                column: "StateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUsAttachment",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "AboutUsOffice",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "AboutUsTeamMember",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "OfficeLocation",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "PersonAttachment",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "TeamMemberSocialMedia",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "TeamMemberState",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "AboutUs",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "Location",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Attachment",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "State",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "TeamMember",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "Office",
                schema: "Main");

            migrationBuilder.DropTable(
                name: "Person",
                schema: "Identity");
        }
    }
}
