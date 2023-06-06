using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace DataAccess.Migrations
{
    public partial class _001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estudante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Matricula = table.Column<string>(type: "varchar(200)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", nullable: false),
                    NomeDoCurso = table.Column<string>(type: "varchar(200)", nullable: false),
                    EstaHabilitado = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudante", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Livro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "varchar(300)", nullable: true),
                    Idioma = table.Column<string>(type: "varchar(200)", nullable: true),
                    AutorId = table.Column<int>(type: "INTEGER", nullable: false),
                    GeneroId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Livro_Autor_AutorId",
                        column: x => x.AutorId,
                        principalTable: "Autor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Livro_Genero_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "Genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Volume",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EstaDisponivel = table.Column<bool>(type: "boolean", nullable: false),
                    LivroId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volume", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Volume_Livro_LivroId",
                        column: x => x.LivroId,
                        principalTable: "Livro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DiaLocado = table.Column<DateTime>(type: "datetime", nullable: false),
                    DiaPrazo = table.Column<DateTime>(type: "datetime", nullable: false),
                    DiaDevolucao = table.Column<DateTime>(type: "datetime", nullable: true),
                    EstaAtrasado = table.Column<bool>(type: "boolean", nullable: false),
                    EstudanteId = table.Column<int>(type: "INTEGER", nullable: false),
                    VolumeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locacao_Estudante_EstudanteId",
                        column: x => x.EstudanteId,
                        principalTable: "Estudante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Locacao_Volume_VolumeId",
                        column: x => x.VolumeId,
                        principalTable: "Volume",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Autor",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Machado de Assis" });

            migrationBuilder.InsertData(
                table: "Autor",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 9, "Neymar Júnior" });

            migrationBuilder.InsertData(
                table: "Autor",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 8, "Wellington Profeta" });

            migrationBuilder.InsertData(
                table: "Autor",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 7, "Joaquim José da Silva Xavier" });

            migrationBuilder.InsertData(
                table: "Autor",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 6, "Maicon Hawking" });

            migrationBuilder.InsertData(
                table: "Autor",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 10, "Lincolm" });

            migrationBuilder.InsertData(
                table: "Autor",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 4, "Sun Tzu" });

            migrationBuilder.InsertData(
                table: "Autor",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 3, "Joana Martin" });

            migrationBuilder.InsertData(
                table: "Autor",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "Cleitin" });

            migrationBuilder.InsertData(
                table: "Autor",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 5, "William Shakespeare" });

            migrationBuilder.InsertData(
                table: "Estudante",
                columns: new[] { "Id", "Email", "EstaHabilitado", "Matricula", "Nome", "NomeDoCurso" },
                values: new object[] { 1, "jose@univali.com", true, "32456789544567", "José Silva", "Análise e Desenvolvimento de Sistemas" });

            migrationBuilder.InsertData(
                table: "Estudante",
                columns: new[] { "Id", "Email", "EstaHabilitado", "Matricula", "Nome", "NomeDoCurso" },
                values: new object[] { 2, "maria@univali.com", true, "8735983759873", "Maria Joaquina", "Nutrição" });

            migrationBuilder.InsertData(
                table: "Genero",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 7, "Suspense" });

            migrationBuilder.InsertData(
                table: "Genero",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 1, "Fantasia" });

            migrationBuilder.InsertData(
                table: "Genero",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 2, "Filosofia" });

            migrationBuilder.InsertData(
                table: "Genero",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 3, "Romance" });

            migrationBuilder.InsertData(
                table: "Genero",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 4, "História" });

            migrationBuilder.InsertData(
                table: "Genero",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 5, "Biografia" });

            migrationBuilder.InsertData(
                table: "Genero",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 6, "Fantasia Científica" });

            migrationBuilder.InsertData(
                table: "Genero",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 8, "Novelas de Cavalaria" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "GeneroId", "Idioma", "Titulo" },
                values: new object[] { 9, 9, 1, "Português", "Como Fazer Mil Embaixadinhas" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "GeneroId", "Idioma", "Titulo" },
                values: new object[] { 3, 4, 2, "Português", "A Arte da Guerra" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "GeneroId", "Idioma", "Titulo" },
                values: new object[] { 2, 1, 3, "Português", "Dom Casmurro" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "GeneroId", "Idioma", "Titulo" },
                values: new object[] { 5, 5, 3, "Português", "Hamlet" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "GeneroId", "Idioma", "Titulo" },
                values: new object[] { 10, 1, 3, "Português", "Memórias Póstumas de Brás Cubas" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "GeneroId", "Idioma", "Titulo" },
                values: new object[] { 6, 7, 4, "Português", "A História do Brasil" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "GeneroId", "Idioma", "Titulo" },
                values: new object[] { 1, 2, 5, "Português", "As Aventuras de Cleitin" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "GeneroId", "Idioma", "Titulo" },
                values: new object[] { 4, 6, 5, "Português", "A Teoria de Tudo" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "GeneroId", "Idioma", "Titulo" },
                values: new object[] { 8, 10, 6, "Português", "Era uma Vez" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "GeneroId", "Idioma", "Titulo" },
                values: new object[] { 7, 8, 7, "Português", "A Profecia Profetizada" });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 14, true, 9 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 7, true, 7 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 13, true, 8 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 12, true, 8 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 9, true, 4 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 8, true, 4 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 4, true, 4 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 1, true, 1 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 6, true, 6 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 18, true, 10 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 17, true, 10 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 16, true, 10 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 5, true, 5 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 2, true, 2 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 3, true, 3 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 15, true, 9 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 10, true, 7 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 11, true, 7 });

            migrationBuilder.CreateIndex(
                name: "IX_Livro_AutorId",
                table: "Livro",
                column: "AutorId");

            migrationBuilder.CreateIndex(
                name: "IX_Livro_GeneroId",
                table: "Livro",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_EstudanteId",
                table: "Locacao",
                column: "EstudanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Locacao_VolumeId",
                table: "Locacao",
                column: "VolumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Volume_LivroId",
                table: "Volume",
                column: "LivroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Locacao");

            migrationBuilder.DropTable(
                name: "Estudante");

            migrationBuilder.DropTable(
                name: "Volume");

            migrationBuilder.DropTable(
                name: "Livro");

            migrationBuilder.DropTable(
                name: "Autor");

            migrationBuilder.DropTable(
                name: "Genero");
        }
    }
}
