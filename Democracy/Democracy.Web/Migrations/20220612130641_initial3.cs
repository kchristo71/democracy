using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Democracy.Web.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PollAttributeValues_Attributes_AttributeId",
                table: "PollAttributeValues");

            migrationBuilder.DropForeignKey(
                name: "FK_PollAttributeValues_Polls_PollId",
                table: "PollAttributeValues");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PollAttributeValues",
                table: "PollAttributeValues");

            migrationBuilder.RenameTable(
                name: "PollAttributeValues",
                newName: "AttributeValue");

            migrationBuilder.RenameIndex(
                name: "IX_PollAttributeValues_PollId",
                table: "AttributeValue",
                newName: "IX_AttributeValue_PollId");

            migrationBuilder.RenameIndex(
                name: "IX_PollAttributeValues_AttributeId",
                table: "AttributeValue",
                newName: "IX_AttributeValue_AttributeId");

            migrationBuilder.AlterColumn<Guid>(
                name: "PollId",
                table: "AttributeValue",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_AttributeValue",
                table: "AttributeValue",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeValue_AttributeValueId",
                table: "AttributeValue",
                column: "AttributeValueId");

            migrationBuilder.AddForeignKey(
                name: "FK_AttributeValue_Attributes_AttributeId",
                table: "AttributeValue",
                column: "AttributeId",
                principalTable: "Attributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AttributeValue_Attributes_AttributeId",
                table: "AttributeValue");

            migrationBuilder.DropForeignKey(
                name: "FK_AttributeValue_AttributeValue_AttributeValueId",
                table: "AttributeValue");

            migrationBuilder.DropForeignKey(
                name: "FK_AttributeValue_Polls_PollId",
                table: "AttributeValue");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AttributeValue",
                table: "AttributeValue");

            migrationBuilder.DropIndex(
                name: "IX_AttributeValue_AttributeValueId",
                table: "AttributeValue");

            migrationBuilder.DropColumn(
                name: "AttributeValueId",
                table: "AttributeValue");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AttributeValue");

            migrationBuilder.RenameTable(
                name: "AttributeValue",
                newName: "PollAttributeValues");

            migrationBuilder.RenameIndex(
                name: "IX_AttributeValue_PollId",
                table: "PollAttributeValues",
                newName: "IX_PollAttributeValues_PollId");

            migrationBuilder.RenameIndex(
                name: "IX_AttributeValue_AttributeId",
                table: "PollAttributeValues",
                newName: "IX_PollAttributeValues_AttributeId");

            migrationBuilder.AlterColumn<Guid>(
                name: "PollId",
                table: "PollAttributeValues",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PollAttributeValues",
                table: "PollAttributeValues",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PollAttributeValues_Attributes_AttributeId",
                table: "PollAttributeValues",
                column: "AttributeId",
                principalTable: "Attributes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PollAttributeValues_Polls_PollId",
                table: "PollAttributeValues",
                column: "PollId",
                principalTable: "Polls",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
