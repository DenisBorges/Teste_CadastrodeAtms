using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CadastrodeAtms.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UFS",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataCadastro = table.Column<DateTime>(nullable: true, defaultValueSql: "date('now')"),
                    DataAtualizacao = table.Column<DateTime>(nullable: true),
                    UfSigla = table.Column<string>(maxLength: 2, nullable: true),
                    UfNome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UFS", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    MunID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataCadastro = table.Column<DateTime>(nullable: true),
                    DataAtualizacao = table.Column<DateTime>(nullable: true),
                    MunNOME = table.Column<string>(nullable: true),
                    MunUF = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MunISS = table.Column<float>(nullable: true),
                    MunICMS = table.Column<float>(nullable: true),
                    MunICMSInterno = table.Column<float>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.MunID);
                    table.ForeignKey(
                        name: "FK_Municipios_UFS_MunUF",
                        column: x => x.MunUF,
                        principalTable: "UFS",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ATMs",
                columns: table => new
                {
                    atmID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    atmDTCADASTRO = table.Column<DateTime>(nullable: true),
                    DataAtualizacao = table.Column<DateTime>(nullable: true),
                    atmPC = table.Column<string>(maxLength: 5, nullable: false),
                    atmNOME = table.Column<string>(maxLength: 50, nullable: true),
                    atmPA = table.Column<int>(nullable: true),
                    atmENDERECO = table.Column<string>(maxLength: 50, nullable: true),
                    atmCOMPLEMENTO = table.Column<string>(maxLength: 20, nullable: true),
                    atmBAIRRO = table.Column<string>(maxLength: 20, nullable: true),
                    atmCIDADE = table.Column<int>(nullable: false),
                    atmUF = table.Column<int>(nullable: false),
                    Ufid = table.Column<int>(nullable: true),
                    atmCEP = table.Column<string>(maxLength: 20, nullable: true),
                    atmPONTOREF = table.Column<string>(maxLength: 50, nullable: true),
                    atmLATITUDE = table.Column<string>(nullable: true),
                    atmLONGITUDE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ATMs", x => x.atmID);
                    table.ForeignKey(
                        name: "FK_ATMs_Municipios_atmCIDADE",
                        column: x => x.atmCIDADE,
                        principalTable: "Municipios",
                        principalColumn: "MunID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ATMs_UFS_Ufid",
                        column: x => x.Ufid,
                        principalTable: "UFS",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 1, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(8711), new DateTime(2020, 4, 7, 21, 17, 7, 566, DateTimeKind.Local).AddTicks(5888), "Acre", "AC" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 25, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9793), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9792), "Goiás", "GO" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 24, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9791), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9790), "Mato Grosso", "MT" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 23, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9789), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9788), "Mato Grosso do Sul", "MS" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 22, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9786), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9785), "Rio Grande do Sul", "RS" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 21, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9784), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9783), "Santa Catarina", "SC" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 20, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9782), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9781), "Paraná", "PR" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 19, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9779), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9778), "São Paulo", "SP" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 18, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9777), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9775), "Rio de Janeiro", "RJ" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 17, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9774), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9773), "Espírito Santo", "ES" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 16, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9772), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9771), "Minas Gerais", "MG" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 15, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9769), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9768), "Bahia", "BA" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 26, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9797), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9795), "Distrito Federal", "DF" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 14, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9767), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9766), "Sergipe", "SE" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 12, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9762), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9761), "Pernambuco", "PE" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 11, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9760), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9759), "Paraíba", "PB" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 10, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9758), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9757), "Rio Grande do Norte", "RN" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 9, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9755), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9754), "Ceará", "CE" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 8, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9753), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9752), "Piauí", "PI" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 7, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9750), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9749), "Maranhão", "MA" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 6, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9748), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9747), "Tocantins", "TO" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 5, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9746), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9744), "Amapá", "AP" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 4, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9743), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9742), "Pará", "PA" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 3, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9740), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9739), "Roraima", "RR" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 2, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9729), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9715), "Amazonas", "AM" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 13, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9765), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9764), "Alagoas", "AL" });

            migrationBuilder.InsertData(
                table: "UFS",
                columns: new[] { "id", "DataAtualizacao", "DataCadastro", "UfNome", "UfSigla" },
                values: new object[] { 27, new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9799), new DateTime(2020, 4, 7, 21, 17, 7, 567, DateTimeKind.Local).AddTicks(9798), "Rondônia", "RO" });

            migrationBuilder.InsertData(
                table: "Municipios",
                columns: new[] { "MunID", "DataAtualizacao", "DataCadastro", "MunNOME", "MunUF" },
                values: new object[] { 1, null, null, "São Paulo", 19 });

            migrationBuilder.InsertData(
                table: "Municipios",
                columns: new[] { "MunID", "DataAtualizacao", "DataCadastro", "MunNOME", "MunUF" },
                values: new object[] { 2, null, null, "Guarulhos", 19 });

            migrationBuilder.CreateIndex(
                name: "IX_ATMs_atmCIDADE",
                table: "ATMs",
                column: "atmCIDADE");

            migrationBuilder.CreateIndex(
                name: "IX_ATMs_Ufid",
                table: "ATMs",
                column: "Ufid");

            migrationBuilder.CreateIndex(
                name: "IX_Municipios_MunUF",
                table: "Municipios",
                column: "MunUF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ATMs");

            migrationBuilder.DropTable(
                name: "Municipios");

            migrationBuilder.DropTable(
                name: "UFS");
        }
    }
}
