﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.IdentityServer.Data.Migrations
{
    public partial class AppDbMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ids_AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    OrderSort = table.Column<int>(nullable: false),
                    Enabled = table.Column<bool>(nullable: false),
                    CreateId = table.Column<int>(nullable: true),
                    CreateBy = table.Column<string>(nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    ModifyId = table.Column<int>(nullable: true),
                    ModifyBy = table.Column<string>(nullable: true),
                    ModifyTime = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ids_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ids_AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    LoginName = table.Column<string>(nullable: true),
                    RealName = table.Column<string>(nullable: true),
                    sex = table.Column<int>(nullable: false),
                    age = table.Column<int>(nullable: false),
                    birth = table.Column<DateTime>(nullable: false),
                    addr = table.Column<string>(nullable: true),
                    tdIsDelete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ids_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ids_AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ids_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ids_AspNetRoleClaims_Ids_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Ids_AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ids_AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ids_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ids_AspNetUserClaims_Ids_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "Ids_AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ids_AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ids_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_Ids_AspNetUserLogins_Ids_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "Ids_AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ids_AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<int>(nullable: true),
                    RoleId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ids_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_Ids_AspNetUserRoles_Ids_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Ids_AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ids_AspNetUserRoles_Ids_AspNetRoles_RoleId1",
                        column: x => x.RoleId1,
                        principalTable: "Ids_AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ids_AspNetUserRoles_Ids_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "Ids_AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ids_AspNetUserRoles_Ids_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Ids_AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ids_AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ids_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_Ids_AspNetUserTokens_Ids_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "Ids_AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ids_AspNetRoleClaims_RoleId",
                table: "Ids_AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Ids_AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Ids_AspNetUserClaims_UserId",
                table: "Ids_AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ids_AspNetUserLogins_UserId",
                table: "Ids_AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ids_AspNetUserRoles_RoleId",
                table: "Ids_AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Ids_AspNetUserRoles_RoleId1",
                table: "Ids_AspNetUserRoles",
                column: "RoleId1");

            migrationBuilder.CreateIndex(
                name: "IX_Ids_AspNetUserRoles_UserId1",
                table: "Ids_AspNetUserRoles",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Ids_AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Ids_AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ids_AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "Ids_AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "Ids_AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "Ids_AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "Ids_AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Ids_AspNetRoles");

            migrationBuilder.DropTable(
                name: "Ids_AspNetUsers");
        }
    }
}
