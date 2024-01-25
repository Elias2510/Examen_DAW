using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EXAMEN.Migrations
{
    public partial class migr1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Evenimente",
                columns: table => new
                {
                    EvenimentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evenimente", x => x.EvenimentId);
                });

            migrationBuilder.CreateTable(
                name: "Participant",
                columns: table => new
                {
                    ParticipantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tip = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participant", x => x.ParticipantId);
                });

            migrationBuilder.CreateTable(
                name: "Clasa3",
                columns: table => new
                {
                    Clasa3Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParticipareId = table.Column<int>(type: "int", nullable: false),
                    EvenimentId = table.Column<int>(type: "int", nullable: false),
                    ParticipantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clasa3", x => x.Clasa3Id);
                    table.ForeignKey(
                        name: "FK_Clasa3_Evenimente_EvenimentId",
                        column: x => x.EvenimentId,
                        principalTable: "Evenimente",
                        principalColumn: "EvenimentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clasa3_Participant_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "Participant",
                        principalColumn: "ParticipantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clasa2",
                columns: table => new
                {
                    Clasa2Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParticipantId = table.Column<int>(type: "int", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clasa3ReferenceClasa3Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clasa2", x => x.Clasa2Id);
                    table.ForeignKey(
                        name: "FK_Clasa2_Clasa3_Clasa3ReferenceClasa3Id",
                        column: x => x.Clasa3ReferenceClasa3Id,
                        principalTable: "Clasa3",
                        principalColumn: "Clasa3Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Clasa1",
                columns: table => new
                {
                    Clasa1Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EvenimentId = table.Column<int>(type: "int", nullable: false),
                    Nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Clasa2ReferenceClasa2Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clasa1", x => x.Clasa1Id);
                    table.ForeignKey(
                        name: "FK_Clasa1_Clasa2_Clasa2ReferenceClasa2Id",
                        column: x => x.Clasa2ReferenceClasa2Id,
                        principalTable: "Clasa2",
                        principalColumn: "Clasa2Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Participari",
                columns: table => new
                {
                    EvenimentId = table.Column<int>(type: "int", nullable: false),
                    ParticipantId = table.Column<int>(type: "int", nullable: false),
                    ParticipareId = table.Column<int>(type: "int", nullable: false),
                    Clasa1Id = table.Column<int>(type: "int", nullable: true),
                    Clasa2Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participari", x => new { x.EvenimentId, x.ParticipantId });
                    table.ForeignKey(
                        name: "FK_Participari_Clasa1_Clasa1Id",
                        column: x => x.Clasa1Id,
                        principalTable: "Clasa1",
                        principalColumn: "Clasa1Id");
                    table.ForeignKey(
                        name: "FK_Participari_Clasa2_Clasa2Id",
                        column: x => x.Clasa2Id,
                        principalTable: "Clasa2",
                        principalColumn: "Clasa2Id");
                    table.ForeignKey(
                        name: "FK_Participari_Evenimente_EvenimentId",
                        column: x => x.EvenimentId,
                        principalTable: "Evenimente",
                        principalColumn: "EvenimentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Participari_Participant_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "Participant",
                        principalColumn: "ParticipantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clasa1_Clasa2ReferenceClasa2Id",
                table: "Clasa1",
                column: "Clasa2ReferenceClasa2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Clasa2_Clasa3ReferenceClasa3Id",
                table: "Clasa2",
                column: "Clasa3ReferenceClasa3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Clasa3_EvenimentId",
                table: "Clasa3",
                column: "EvenimentId");

            migrationBuilder.CreateIndex(
                name: "IX_Clasa3_ParticipantId",
                table: "Clasa3",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_Participari_Clasa1Id",
                table: "Participari",
                column: "Clasa1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Participari_Clasa2Id",
                table: "Participari",
                column: "Clasa2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Participari_ParticipantId",
                table: "Participari",
                column: "ParticipantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Participari");

            migrationBuilder.DropTable(
                name: "Clasa1");

            migrationBuilder.DropTable(
                name: "Clasa2");

            migrationBuilder.DropTable(
                name: "Clasa3");

            migrationBuilder.DropTable(
                name: "Evenimente");

            migrationBuilder.DropTable(
                name: "Participant");
        }
    }
}
