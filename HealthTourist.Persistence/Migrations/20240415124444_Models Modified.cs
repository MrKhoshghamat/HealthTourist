using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HealthTourist.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ModelsModified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeamMemberAttachment",
                schema: "Interface",
                columns: table => new
                {
                    TeamMemberId = table.Column<long>(type: "bigint", nullable: false),
                    AttachmentId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMemberAttachment", x => new { x.TeamMemberId, x.AttachmentId });
                    table.ForeignKey(
                        name: "FK_TeamMemberAttachment_Attachment_AttachmentId",
                        column: x => x.AttachmentId,
                        principalSchema: "dbo",
                        principalTable: "Attachment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeamMemberAttachment_TeamMember_TeamMemberId",
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
                    TeamMemberId = table.Column<long>(type: "bigint", nullable: false),
                    SocialMedia = table.Column<int>(type: "integer", nullable: false),
                    Link = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMemberSocialMedia", x => x.TeamMemberId);
                    table.ForeignKey(
                        name: "FK_TeamMemberSocialMedia_TeamMember_TeamMemberId",
                        column: x => x.TeamMemberId,
                        principalSchema: "Main",
                        principalTable: "TeamMember",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeamMemberAttachment_AttachmentId",
                schema: "Interface",
                table: "TeamMemberAttachment",
                column: "AttachmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamMemberAttachment",
                schema: "Interface");

            migrationBuilder.DropTable(
                name: "TeamMemberSocialMedia",
                schema: "Interface");
        }
    }
}
