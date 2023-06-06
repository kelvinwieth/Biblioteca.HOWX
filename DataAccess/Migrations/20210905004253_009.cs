using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class _009 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locacao",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Livro",
                type: "varchar(500)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 1,
                column: "Descricao",
                value: "Verdadeiro clássico moderno, concebido por um dos mais influentes escritores do século XX, A revolução dos bichos é uma fábula sobre o poder. Narra a insurreição dos animais de uma granja contra seus donos. Progressivamente, porém, a revolução degenera numa tirania ainda mais opressiva que a dos humanos.");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 2,
                column: "Descricao",
                value: "Um clássico da literatura mundial, esta obra é uma poderosa denúncia a todos os tipos de injustiça humana. Narra a emocionante história de Jean Valjean ― o homem que, por ter roubado um pão, é condenado a dezenove anos de prisão. Os miseráveis é um livro inquietantemente religioso e político, com uma das narrativas mais envolventes já criadas.");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 3,
                column: "Descricao",
                value: "A República (ou Da Justiça) é a obra mais traduzida, difundida, influente e estudada de Platão. Consagrada como um dos mais expressivos escritos de filosofia de todos os tempos, teve seu texto estabelecido por diversos helenistas ilustres. Esta obra aborda diversos temas fundamentados, centrados e subordinados à questão primordial \"o que é a justiça ?\" e seus desdobramentos: \"qual é a sua natureza ?\" e \"do que é ela constituída ?\".");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 4,
                column: "Descricao",
                value: "Além do bem e do mal – Prelúdio a uma filosofia do futuro foi publicado pela primeira vez em 1886, com base nas anotações de Nietzsche para a composição de outra de suas obras: Assim falou Zaratustra (esta, publicada pela primeira vez em 1891).");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 5,
                column: "Descricao",
                value: "Orgulho e preconceito é o livro mais famoso de Jane Austen e possui uma série de personagens inesquecíveis e um enredo memorável. Austen nos apresenta Elizabeth Bennet como heroína irresistível e seu pretendente aristocrático, o sr. Darcy.");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Descricao", "Idioma" },
                values: new object[] { "During an eventful season at Bath, young, naïve Catherine Morland experiences the joys of fashionable society for the first time. She is delighted with her new acquaintances: flirtatious Isabella, who shares Catherine's love of Gothic romance and horror, and sophisticated Henry and Eleanor Tilney, who invite her to their father's mysterious house, Northanger Abbey.", "Inglês" });

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 7,
                column: "Descricao",
                value: "Em 1822, o escritor compara diferentes relatos sobre o dia 7 de setembro que redefiniu os rumos do nosso país. Mais do que desmistificar o grito da independência às margens do Ipiranga, o escritor analisa como D. Pedro conseguiu, apesar de todas as dificuldades, fazer do Brasil uma nação de proporções monumentais.");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 8,
                column: "Descricao",
                value: "O que faz de um tratado militar, escrito por volta de 500 a.C., manter-se atual a ponto de ser publicado praticamente no mundo todo até os dias de hoje? Você verá que, em A arte da guerra, as estratégias transmitidas pelo general chinês Sun Tzu carregam um profundo conhecimento da natureza humana.");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 9,
                column: "Descricao",
                value: "\"Ayrton Senna – Uma lenda a toda velocidade\" contém 13 luxuosos envelopes com réplicas de cartas escritas à mão, de agendas de corridas, de adesivos de escuderia autografados, entre outros itens especiais.");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Descricao", "Titulo" },
                values: new object[] { "Nesta que pode ser considerada sua biografia definitiva, o grande historiador francês Pierre Grimal, um apaixonado pela civilização romana, explica por que Marco Aurélio foi o maior dos imperadores - o mais humano, o mais sábio, o mais justo.", "Marco Aurélio: O imperador filósofo" });

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 11,
                column: "Descricao",
                value: "No futuro, existe a matrix. Uma espécie de alucinação coletiva digital na qual a humanidade se conecta para, virtualmente, saber de tudo sobre tudo. Mas há uma elite que navega por essa grande rede de informação - os cowboys.");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 12,
                column: "Descricao",
                value: "Mil Novecentos e Oitenta e Quatro, muitas vezes publicado como 1984, é um romance distópico da autoria do escritor britânico George Orwell e publicado em 1949.");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 13,
                column: "Descricao",
                value: "Durante as férias de 1958, em uma pacata cidadezinha do Maine, Bill, Richie, Stan, Mike, Eddie, Ben e Beverly aprenderam o real sentido da amizade, do amor, da confiança... e do medo. O mais profundo e tenebroso medo. Naquele verão, eles enfrentaram pela primeira vez a Coisa, um ser sobrenatural e maligno que deixou terríveis marcas de sangue em Derry.");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Descricao", "Titulo" },
                values: new object[] { "O corpo de um menino de onze anos é encontrado abandonado no parque de Flint City, brutalmente assassinado. Testemunhas e impressões digitais apontam o criminoso como uma das figuras mais conhecidas da cidade — Terry Maitland, treinador da Liga Infantil de beisebol, professor de inglês, casado e pai de duas filhas.", "Outsider" });

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 15,
                column: "Descricao",
                value: "Ninguém sabe ao certo quem é o herói ou o vilão desse fascinante universo criado por Patrick Rothfuss. Na realidade, essas duas figuras se concentram em Kote, um homem enigmático que se esconde sob a identidade de proprietário da hospedaria Marco do Percurso.");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 16,
                column: "Descricao",
                value: "Quando virou o envelope, com a mão trêmula, Harry viu um lacre de cera púrpura com um brasão; um leão, uma águia, um texugo e uma cobra circulando uma grande letra \"H\".");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 17,
                column: "Descricao",
                value: "Quatro décadas após chocar o mundo inteiro, a obra-prima de terror de William Peter Blatty permanece uma metáfora moderna do combate entre a fé e o profano na forma de um dos romances mais macabros já escritos.");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 18,
                column: "Descricao",
                value: "Livro com mais de 170 mil exemplares vendidos no Brasil é inspiração para novo lançamento da Netflix. Com uma trama cheia de suspense e terror psicológico, Caixa de pássaros explora a essência do medo em um mundo pós-apocalíptico.");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 19,
                column: "Descricao",
                value: "Nas últimas semanas de 1889, a tripulação de um navio de guerra brasileiro ancorado no porto de Colombo, capital do Ceilão (atual Sri Lanka), foi pega de surpresa pelas notícias alarmantes que chegavam do outro lado do mundo. O Brasil havia se tornado uma república.");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 20,
                column: "Descricao",
                value: "O objetivo deste livro é ajudar o leitor a pensar com a sua própria cabeça. Para tal, o filósofo e escritor Luiz Felipe Pondé, autor de vários best-sellers, se apoia na história da filosofia para apresentar argumentos para quem quer discutir todo e qualquer tipo de assunto com embasamento.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Livro");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 6,
                column: "Idioma",
                value: "Português");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 10,
                column: "Titulo",
                value: "Marco Aurélio: O imperador filósofo ");

            migrationBuilder.UpdateData(
                table: "Livro",
                keyColumn: "Id",
                keyValue: 14,
                column: "Titulo",
                value: "The Outsider");

            migrationBuilder.InsertData(
                table: "Locacao",
                columns: new[] { "Id", "DiaDevolucao", "DiaLocado", "DiaPrazo", "EstaAtrasado", "EstudanteId", "VolumeId" },
                values: new object[] { 1, null, new DateTime(2021, 9, 2, 11, 19, 46, 447, DateTimeKind.Local).AddTicks(5360), new DateTime(2021, 9, 9, 11, 19, 46, 460, DateTimeKind.Local).AddTicks(77), false, 4, 1 });
        }
    }
}
