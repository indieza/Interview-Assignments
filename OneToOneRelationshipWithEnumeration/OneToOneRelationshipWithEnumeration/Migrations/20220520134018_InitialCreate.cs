// <copyright file="20220520134018_InitialCreate.cs" company="One To One Relationship With Enumeration">
// Copyright (c) One To One Relationship With Enumeration. All rights reserved.
// </copyright>

#nullable disable

namespace OneToOneRelationshipWithEnumeration.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseUserAction",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ActionType = table.Column<int>(type: "int", nullable: false),
                    UserActionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseUserAction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FollowUserActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FollowMessage = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowUserActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FollowUserActions_BaseUserAction_Id",
                        column: x => x.Id,
                        principalTable: "BaseUserAction",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UnfollowUserActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UnfollowMessage = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnfollowUserActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnfollowUserActions_BaseUserAction_Id",
                        column: x => x.Id,
                        principalTable: "BaseUserAction",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserActions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BaseUserActionId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserActions_BaseUserAction_BaseUserActionId",
                        column: x => x.BaseUserActionId,
                        principalTable: "BaseUserAction",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserActions_BaseUserActionId",
                table: "UserActions",
                column: "BaseUserActionId",
                unique: true,
                filter: "[BaseUserActionId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FollowUserActions");

            migrationBuilder.DropTable(
                name: "UnfollowUserActions");

            migrationBuilder.DropTable(
                name: "UserActions");

            migrationBuilder.DropTable(
                name: "BaseUserAction");
        }
    }
}