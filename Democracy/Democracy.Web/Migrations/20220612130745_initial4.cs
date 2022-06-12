using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Democracy.Web.Migrations
{
    public partial class initial4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttributeValue_AttributeValue_AttributeValueId",
                table: "AttributeValue");

            migrationBuilder.DropForeignKey(
                name: "FK_AttributeValue_Polls_PollId",
                table: "AttributeValue");

            migrationBuilder.DropIndex(
                name: "IX_AttributeValue_AttributeValueId",
                table: "AttributeValue");

            migrationBuilder.DropIndex(
                name: "IX_AttributeValue_PollId",
                table: "AttributeValue");

            migrationBuilder.DropColumn(
                name: "AttributeValueId",
                table: "AttributeValue");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AttributeValue");

            migrationBuilder.DropColumn(
                name: "PollId",
                table: "AttributeValue");

            migrationBuilder.CreateTable(
                name: "PollAttributeValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    PollId = table.Column<Guid>(type: "uuid", nullable: false),
                    AttributeValueId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PollAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PollAttributeValues_AttributeValue_AttributeValueId",
                        column: x => x.AttributeValueId,
                        principalTable: "AttributeValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PollAttributeValues_Polls_PollId",
                        column: x => x.PollId,
                        principalTable: "Polls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PollAttributeValues_AttributeValueId",
                table: "PollAttributeValues",
                column: "AttributeValueId");

            migrationBuilder.CreateIndex(
                name: "IX_PollAttributeValues_PollId",
                table: "PollAttributeValues",
                column: "PollId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PollAttributeValues");

            migrationBuilder.AddColumn<Guid>(
                name: "AttributeValueId",
                table: "AttributeValue",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AttributeValue",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "PollId",
                table: "AttributeValue",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AttributeValue_AttributeValueId",
                table: "AttributeValue",
                column: "AttributeValueId");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeValue_PollId",
                table: "AttributeValue",
                column: "PollId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeValue_AttributeValue_AttributeValueId",
                table: "AttributeValue",
                column: "AttributeValueId",
                principalTable: "AttributeValue",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeValue_Polls_PollId",
                table: "AttributeValue",
                column: "PollId",
                principalTable: "Polls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
