using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class _002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Estudante",
                type: "varchar(4)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nome",
                value: "George Orwell");

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nome",
                value: "Victor Hugo");

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nome",
                value: "Platão");

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 4,
                column: "Nome",
                value: "Friedrich Nietzsche");

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 5,
                column: "Nome",
                value: "Jane Austen");

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 6,
                column: "Nome",
                value: "Laurentino Gomes");

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 7,
                column: "Nome",
                value: "Sun Tzu");

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 8,
                column: "Nome",
                value: "Christopher Hilton");

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 9,
                column: "Nome",
                value: "Pierre Grimal");

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 10,
                column: "Nome",
                value: "William Gibson");

            migrationBuilder.InsertData(
                table: "Autor",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 11, "Stephen King" });

            migrationBuilder.InsertData(
                table: "Autor",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 12, "Patrick Rothfuss" });

            migrationBuilder.InsertData(
                table: "Autor",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 13, "J. K. Rowling" });

            migrationBuilder.InsertData(
                table: "Autor",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 14, "William Peter Blatty" });

            migrationBuilder.InsertData(
                table: "Autor",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 15, "Josh Malerman" });

            migrationBuilder.InsertData(
                table: "Autor",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 16, "Luis Felipe Pondé" });

            migrationBuilder.UpdateData(
                table: "Estudante",
                keyColumn: "Id",
                keyValue: 1,
                column: "Senha",
                value: "1234");

            migrationBuilder.UpdateData(
                table: "Estudante",
                keyColumn: "Id",
                keyValue: 2,
                column: "Senha",
                value: "2345");

            migrationBuilder.InsertData(
                table: "Estudante",
                columns: new[] { "Id", "Email", "EstaHabilitado", "Matricula", "Nome", "NomeDoCurso", "Senha" },
                values: new object[] { 7, "LeandroPintarelli@univali.com", true, "2158621864152", "Leandro Pintarelli da Souza", "Estética", "7890" });

            migrationBuilder.InsertData(
                table: "Estudante",
                columns: new[] { "Id", "Email", "EstaHabilitado", "Matricula", "Nome", "NomeDoCurso", "Senha" },
                values: new object[] { 3, "luis@univali.com", true, "4946137609812", "Luis Oliveira", "Engenharia Mecânica", "3456" });

            migrationBuilder.InsertData(
                table: "Estudante",
                columns: new[] { "Id", "Email", "EstaHabilitado", "Matricula", "Nome", "NomeDoCurso", "Senha" },
                values: new object[] { 4, "loretz@univali.com", true, "6661235786664", "Lindomar Pinto", "Artes Visuais", "4567" });

            migrationBuilder.InsertData(
                table: "Estudante",
                columns: new[] { "Id", "Email", "EstaHabilitado", "Matricula", "Nome", "NomeDoCurso", "Senha" },
                values: new object[] { 5, "suce@univali.com", true, "9995836462424", "Getulio Silva", "Biomedicina", "5678" });

            migrationBuilder.InsertData(
                table: "Estudante",
                columns: new[] { "Id", "Email", "EstaHabilitado", "Matricula", "Nome", "NomeDoCurso", "Senha" },
                values: new object[] { 6, "Larissa@univali.com", true, "6661235786664", "Larissa da Souza Santos", "Design de Jogos e Entretenimento Digital", "6789" });

            migrationBuilder.InsertData(
                table: "Estudante",
                columns: new[] { "Id", "Email", "EstaHabilitado", "Matricula", "Nome", "NomeDoCurso", "Senha" },
                values: new object[] { 8, "Peter@Univali.com", true, "1318671238971", "Peter Santos", "Gestão Pública", "0369" });

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nome",
                value: "Drama");

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 6,
                column: "Nome",
                value: "Ficção Científica");

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 8,
                column: "Nome",
                value: "Aventura");

            migrationBuilder.InsertData(
                table: "Genero",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 9, "Terror" });

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AutorId", "GeneroId", "Titulo" },
                values: new object[] { 1, 1, "A revolução dos bichos" });

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AutorId", "GeneroId", "Titulo" },
                values: new object[] { 2, 1, "Os Miseráveis" });

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AutorId", "Titulo" },
                values: new object[] { 3, "A República" });

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AutorId", "GeneroId", "Titulo" },
                values: new object[] { 4, 2, "Além do Bem e do Mal" });

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 5,
                column: "Titulo",
                value: "Orgulho e Preconceito");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AutorId", "GeneroId", "Titulo" },
                values: new object[] { 5, 3, "Northanger Abbey" });

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AutorId", "GeneroId", "Titulo" },
                values: new object[] { 6, 4, "1822" });

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AutorId", "GeneroId", "Titulo" },
                values: new object[] { 7, 4, "A Arte da Guerra" });

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AutorId", "GeneroId", "Titulo" },
                values: new object[] { 8, 5, "Ayrton Senna: Uma Lenda a Toda Velocidade" });

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AutorId", "GeneroId", "Titulo" },
                values: new object[] { 9, 5, "Marco Aurélio: O imperador filósofo " });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "GeneroId", "Idioma", "Titulo" },
                values: new object[] { 19, 6, 4, "Português", "1889" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "GeneroId", "Idioma", "Titulo" },
                values: new object[] { 12, 1, 6, "Português", "1984" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "GeneroId", "Idioma", "Titulo" },
                values: new object[] { 11, 10, 6, "Português", "Neuromancer" });

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 2,
                column: "LivroId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 3,
                column: "LivroId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 4,
                column: "LivroId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 5,
                column: "LivroId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 6,
                column: "LivroId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 7,
                column: "LivroId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 8,
                column: "LivroId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 9,
                column: "LivroId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 10,
                column: "LivroId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 11,
                column: "LivroId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 12,
                column: "LivroId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 13,
                column: "LivroId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 14,
                column: "LivroId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 15,
                column: "LivroId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 16,
                column: "LivroId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 17,
                column: "LivroId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 18,
                column: "LivroId",
                value: 6);

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 19, true, 7 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 26, true, 9 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 28, true, 10 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 29, true, 10 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 30, true, 10 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 25, true, 9 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 24, true, 8 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 23, true, 8 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 22, true, 8 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 21, true, 7 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 20, true, 7 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 27, true, 9 });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "GeneroId", "Idioma", "Titulo" },
                values: new object[] { 13, 11, 7, "Português", "It - A Coisa" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "GeneroId", "Idioma", "Titulo" },
                values: new object[] { 14, 11, 7, "Português", "The Outsider" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "GeneroId", "Idioma", "Titulo" },
                values: new object[] { 15, 12, 8, "Português", "O Nome do Vento" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "GeneroId", "Idioma", "Titulo" },
                values: new object[] { 16, 13, 8, "Português", "Harry Potter e a Pedra Filosofal" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "GeneroId", "Idioma", "Titulo" },
                values: new object[] { 20, 16, 2, "Português", "Filosofia para corajosos" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "GeneroId", "Idioma", "Titulo" },
                values: new object[] { 17, 14, 9, "Português", "O Exorcista" });

            migrationBuilder.InsertData(
                table: "Livro",
                columns: new[] { "Id", "AutorId", "GeneroId", "Idioma", "Titulo" },
                values: new object[] { 18, 15, 9, "Português", "Caixa de Pássaros" });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 31, true, 11 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 32, true, 11 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 33, true, 11 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 34, true, 12 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 35, true, 12 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 36, true, 12 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 55, true, 19 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 56, true, 19 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 57, true, 19 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 37, true, 13 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 52, true, 18 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 51, true, 17 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 50, true, 17 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 49, true, 17 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 60, true, 20 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 59, true, 20 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 58, true, 20 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 48, true, 16 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 53, true, 18 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 47, true, 16 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 45, true, 15 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 44, true, 15 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 43, true, 15 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 42, true, 14 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 41, true, 14 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 40, true, 14 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 39, true, 13 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 38, true, 13 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 46, true, 16 });

            migrationBuilder.InsertData(
                table: "Volume",
                columns: new[] { "Id", "EstaDisponivel", "LivroId" },
                values: new object[] { 54, true, 18 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Estudante",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Estudante",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Estudante",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Estudante",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Estudante",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Estudante",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Estudante");

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nome",
                value: "Machado de Assis");

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nome",
                value: "Cleitin");

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 3,
                column: "Nome",
                value: "Joana Martin");

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 4,
                column: "Nome",
                value: "Sun Tzu");

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 5,
                column: "Nome",
                value: "William Shakespeare");

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 6,
                column: "Nome",
                value: "Maicon Hawking");

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 7,
                column: "Nome",
                value: "Joaquim José da Silva Xavier");

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 8,
                column: "Nome",
                value: "Wellington Profeta");

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 9,
                column: "Nome",
                value: "Neymar Júnior");

            migrationBuilder.UpdateData(
                table: "Autor",
                keyColumn: "Id",
                keyValue: 10,
                column: "Nome",
                value: "Lincolm");

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nome",
                value: "Fantasia");

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 6,
                column: "Nome",
                value: "Fantasia Científica");

            migrationBuilder.UpdateData(
                table: "Genero",
                keyColumn: "Id",
                keyValue: 8,
                column: "Nome",
                value: "Novelas de Cavalaria");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AutorId", "GeneroId", "Titulo" },
                values: new object[] { 2, 5, "As Aventuras de Cleitin" });

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AutorId", "GeneroId", "Titulo" },
                values: new object[] { 1, 3, "Dom Casmurro" });

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AutorId", "Titulo" },
                values: new object[] { 4, "A Arte da Guerra" });

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AutorId", "GeneroId", "Titulo" },
                values: new object[] { 6, 5, "A Teoria de Tudo" });

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 5,
                column: "Titulo",
                value: "Hamlet");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AutorId", "GeneroId", "Titulo" },
                values: new object[] { 7, 4, "A História do Brasil" });

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AutorId", "GeneroId", "Titulo" },
                values: new object[] { 8, 7, "A Profecia Profetizada" });

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AutorId", "GeneroId", "Titulo" },
                values: new object[] { 10, 6, "Era uma Vez" });

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AutorId", "GeneroId", "Titulo" },
                values: new object[] { 9, 1, "Como Fazer Mil Embaixadinhas" });

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AutorId", "GeneroId", "Titulo" },
                values: new object[] { 1, 3, "Memórias Póstumas de Brás Cubas" });

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 2,
                column: "LivroId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 3,
                column: "LivroId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 4,
                column: "LivroId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 5,
                column: "LivroId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 6,
                column: "LivroId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 7,
                column: "LivroId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 8,
                column: "LivroId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 9,
                column: "LivroId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 10,
                column: "LivroId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 11,
                column: "LivroId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 12,
                column: "LivroId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 13,
                column: "LivroId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 14,
                column: "LivroId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 15,
                column: "LivroId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 16,
                column: "LivroId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 17,
                column: "LivroId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Volume",
                keyColumn: "Id",
                keyValue: 18,
                column: "LivroId",
                value: 10);
        }
    }
}
