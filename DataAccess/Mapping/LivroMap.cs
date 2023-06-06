using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Mapping
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");

            builder.HasKey(l => l.Id);

            builder.Property(l => l.Titulo)
                .HasColumnType("varchar(300)");

            builder.Property(l => l.Idioma)
                .HasColumnType("varchar(200)");

            builder.Property(l => l.FotoUrl)
                .HasColumnType("varchar(300)");

            builder.Property(l => l.Descricao)
                .HasColumnType("varchar(500)");

            builder.HasMany(l => l.Volumes)
                .WithOne(v => v.Livro)
                .HasForeignKey(v => v.LivroId);

            builder.HasOne(l => l.Genero)
                .WithMany(g => g.Livros)
                .HasForeignKey(l => l.GeneroId);

            builder.HasOne(l => l.Autor)
                .WithMany(a => a.Livros)
                .HasForeignKey(l => l.AutorId);

            builder.HasData(GetLivros());
        }

        public List<Livro> GetLivros()
        {
            var livros = new List<Livro>()
            {
                new Livro()
                {
                    Id = 1,
                    Titulo = "A revolução dos bichos",
                    AutorId = 1,
                    GeneroId = 1,
                    FotoUrl = "https://i.imgur.com/DqaowIO.jpg",
                    Descricao =
                        "Verdadeiro clássico moderno, concebido por um dos mais influentes escritores do século XX, " +
                        "A revolução dos bichos é uma fábula sobre o poder. Narra a insurreição dos animais de uma granja contra seus donos. " +
                        "Progressivamente, porém, a revolução degenera numa tirania ainda mais opressiva que a dos humanos."
                },
                new Livro()
                {
                    Id = 2,
                    Titulo = "Os Miseráveis",
                    AutorId = 2,
                    GeneroId = 1,
                    FotoUrl = "https://i.imgur.com/DCTgKSH.jpg",
                    Descricao =
                        "Um clássico da literatura mundial, esta obra é uma poderosa denúncia a todos os tipos de injustiça humana. " +
                        "Narra a emocionante história de Jean Valjean ― o homem que, por ter roubado um pão, é condenado a dezenove anos de prisão. " +
                        "Os miseráveis é um livro inquietantemente religioso e político, com uma das narrativas mais envolventes já criadas."
                },
                new Livro()
                {
                    Id = 3,
                    Titulo = "A República",
                    AutorId = 3,
                    GeneroId = 2,
                    FotoUrl = "https://i.imgur.com/k4Z4I2l.jpg",
                    Descricao =
                        "A República (ou Da Justiça) é a obra mais traduzida, difundida, influente e estudada de Platão. " +
                        "Consagrada como um dos mais expressivos escritos de filosofia de todos os tempos, " +
                        "teve seu texto estabelecido por diversos helenistas ilustres. " +
                        "Esta obra aborda diversos temas fundamentados, centrados e subordinados à questão primordial \"o que é a justiça ?\" " +
                        "e seus desdobramentos: \"qual é a sua natureza ?\" e \"do que é ela constituída ?\"."
                },
                new Livro()
                {
                    Id = 4,
                    Titulo = "Além do Bem e do Mal",
                    AutorId = 4,
                    GeneroId = 2,
                    FotoUrl = "https://i.imgur.com/tlApF7U.jpg",
                    Descricao =
                        "Além do bem e do mal – Prelúdio a uma filosofia do futuro foi publicado pela primeira vez em 1886, " +
                        "com base nas anotações de Nietzsche para a composição de outra de suas obras: " +
                        "Assim falou Zaratustra (esta, publicada pela primeira vez em 1891)."
                },
                new Livro()
                {
                    Id = 5,
                    Titulo = "Orgulho e Preconceito",
                    AutorId = 5,
                    GeneroId = 3,
                    FotoUrl = "https://i.imgur.com/uShdCOu.jpg",
                    Descricao =
                        "Orgulho e preconceito é o livro mais famoso de Jane Austen e possui uma série de personagens inesquecíveis e um enredo memorável. " +
                        "Austen nos apresenta Elizabeth Bennet como heroína irresistível e seu pretendente aristocrático, o sr. Darcy."
                },
                new Livro()
                {
                    Id = 6,
                    Titulo = "Northanger Abbey",
                    AutorId = 5,
                    GeneroId = 3,
                    FotoUrl = "https://i.imgur.com/I89ETSR.jpg",
                    Idioma = "Inglês",
                    Descricao =
                        "During an eventful season at Bath, young, naïve Catherine Morland experiences the joys of fashionable society for the first time. " +
                        "She is delighted with her new acquaintances: flirtatious Isabella, who shares Catherine's love of Gothic romance and horror, " +
                        "and sophisticated Henry and Eleanor Tilney, who invite her to their father's mysterious house, Northanger Abbey."
                },
                new Livro()
                {
                    Id = 7,
                    Titulo = "1822",
                    AutorId = 6,
                    GeneroId = 4,
                    FotoUrl = "https://i.imgur.com/wnp7Laf.jpg",
                    Descricao =
                        "Em 1822, o escritor compara diferentes relatos sobre o dia 7 de setembro que redefiniu os rumos do nosso país. " +
                        "Mais do que desmistificar o grito da independência às margens do Ipiranga, o escritor analisa como D. Pedro conseguiu, " +
                        "apesar de todas as dificuldades, fazer do Brasil uma nação de proporções monumentais."
                },
                new Livro()
                {
                    Id = 8,
                    Titulo = "A Arte da Guerra",
                    AutorId = 7,
                    GeneroId = 4,
                    FotoUrl = "https://i.imgur.com/daJE9SS.jpg",
                    Descricao =
                        "O que faz de um tratado militar, escrito por volta de 500 a.C., manter-se atual a ponto de ser publicado " +
                        "praticamente no mundo todo até os dias de hoje? Você verá que, em A arte da guerra, as estratégias transmitidas " +
                        "pelo general chinês Sun Tzu carregam um profundo conhecimento da natureza humana."
                },
                new Livro()
                {
                    Id = 9,
                    Titulo = "Ayrton Senna: Uma Lenda a Toda Velocidade",
                    AutorId = 8,
                    GeneroId = 5,
                    FotoUrl = "https://i.imgur.com/DPKc8P3.jpg",
                    Descricao =
                        "\"Ayrton Senna – Uma lenda a toda velocidade\" contém 13 luxuosos envelopes com réplicas de cartas escritas à mão, " +
                        "de agendas de corridas, de adesivos de escuderia autografados, entre outros itens especiais."
                },
                new Livro()
                {
                    Id = 10,
                    Titulo = "Marco Aurélio: O imperador filósofo",
                    AutorId = 9,
                    GeneroId = 5,
                    FotoUrl = "https://i.imgur.com/k1HO1zQ.jpg",
                    Descricao =
                        "Nesta que pode ser considerada sua biografia definitiva, o grande historiador francês Pierre Grimal, " +
                        "um apaixonado pela civilização romana, explica por que Marco Aurélio foi o maior dos imperadores - o mais humano, o mais sábio, o mais justo."
                },
                new Livro()
                {
                    Id = 11,
                    Titulo = "Neuromancer",
                    AutorId = 10,
                    GeneroId = 6,
                    FotoUrl = "https://i.imgur.com/5OeUSZc.jpg",
                    Descricao =
                        "No futuro, existe a matrix. Uma espécie de alucinação coletiva digital na qual a humanidade se conecta para, virtualmente, saber de tudo sobre tudo. " +
                        "Mas há uma elite que navega por essa grande rede de informação - os cowboys."
                },
                new Livro()
                {
                    Id = 12,
                    Titulo = "1984",
                    AutorId = 1,
                    GeneroId = 6,
                    FotoUrl = "https://i.imgur.com/Of9C7qm.jpg",
                    Descricao =
                        "Mil Novecentos e Oitenta e Quatro, muitas vezes publicado como 1984, " +
                        "é um romance distópico da autoria do escritor britânico George Orwell e publicado em 1949."
                },
                new Livro()
                {
                    Id = 13,
                    Titulo = "It - A Coisa",
                    AutorId = 11,
                    GeneroId = 7,
                    FotoUrl = "https://i.imgur.com/NUo4xJE.jpg",
                    Descricao =
                        "Durante as férias de 1958, em uma pacata cidadezinha do Maine, Bill, Richie, Stan, Mike, Eddie, Ben e Beverly " +
                        "aprenderam o real sentido da amizade, do amor, da confiança... e do medo. O mais profundo e tenebroso medo. " +
                        "Naquele verão, eles enfrentaram pela primeira vez a Coisa, um ser sobrenatural e maligno que deixou terríveis marcas de sangue em Derry."
                },
                new Livro()
                {
                    Id = 14,
                    Titulo = "Outsider",
                    AutorId = 11,
                    GeneroId = 7,
                    FotoUrl = "https://i.imgur.com/17hchGL.jpg",
                    Descricao =
                        "O corpo de um menino de onze anos é encontrado abandonado no parque de Flint City, brutalmente assassinado. " +
                        "Testemunhas e impressões digitais apontam o criminoso como uma das figuras mais conhecidas da cidade — Terry Maitland, " +
                        "treinador da Liga Infantil de beisebol, professor de inglês, casado e pai de duas filhas."
                },
                new Livro()
                {
                    Id = 15,
                    Titulo = "O Nome do Vento",
                    AutorId = 12,
                    GeneroId = 8,
                    FotoUrl = "https://i.imgur.com/Yf6mLFV.jpg",
                    Descricao =
                        "Ninguém sabe ao certo quem é o herói ou o vilão desse fascinante universo criado por Patrick Rothfuss. " +
                        "Na realidade, essas duas figuras se concentram em Kote, um homem enigmático que se esconde sob a identidade de " +
                        "proprietário da hospedaria Marco do Percurso."
                },
                new Livro()
                {
                    Id = 16,
                    Titulo = "Harry Potter e a Pedra Filosofal",
                    AutorId = 13,
                    GeneroId = 8,
                    FotoUrl = "https://i.imgur.com/BkUoUMT.jpg",
                    Descricao =
                        "Quando virou o envelope, com a mão trêmula, Harry viu um lacre de cera púrpura com um brasão; " +
                        "um leão, uma águia, um texugo e uma cobra circulando uma grande letra \"H\"."
                },
                new Livro()
                {
                    Id = 17,
                    Titulo = "O Exorcista",
                    AutorId = 14,
                    GeneroId = 9,
                    FotoUrl = "https://i.imgur.com/rSMPT8C.jpg",
                    Descricao =
                        "Quatro décadas após chocar o mundo inteiro, a obra-prima de terror de William Peter Blatty permanece " +
                        "uma metáfora moderna do combate entre a fé e o profano na forma de um dos romances mais macabros já escritos."
                },
                new Livro()
                {
                    Id = 18,
                    Titulo = "Caixa de Pássaros",
                    AutorId = 15,
                    GeneroId = 9,
                    FotoUrl = "https://i.imgur.com/FWKpcKo.jpg",
                    Descricao =
                        "Livro com mais de 170 mil exemplares vendidos no Brasil é inspiração para novo lançamento da Netflix. " +
                        "Com uma trama cheia de suspense e terror psicológico, Caixa de pássaros explora a essência do medo em um mundo pós-apocalíptico."
                },
                new Livro()
                {
                    Id = 19,
                    Titulo = "1889",
                    AutorId = 6,
                    GeneroId = 4,
                    FotoUrl = "https://i.imgur.com/ZrbNMoP.jpg",
                    Descricao =
                        "Nas últimas semanas de 1889, a tripulação de um navio de guerra brasileiro ancorado no porto de Colombo, capital do Ceilão (atual Sri Lanka), " +
                        "foi pega de surpresa pelas notícias alarmantes que chegavam do outro lado do mundo. O Brasil havia se tornado uma república."
                },
                new Livro()
                {
                    Id = 20,
                    Titulo = "Filosofia para corajosos",
                    AutorId = 16,
                    GeneroId = 2,
                    FotoUrl = "https://i.imgur.com/H8n63fg.jpg",
                    Descricao =
                        "O objetivo deste livro é ajudar o leitor a pensar com a sua própria cabeça. " +
                        "Para tal, o filósofo e escritor Luiz Felipe Pondé, autor de vários best-sellers, se apoia na história da filosofia para apresentar argumentos " +
                        "para quem quer discutir todo e qualquer tipo de assunto com embasamento."
                },
            };

            livros.Where(l => string.IsNullOrEmpty(l.Idioma)).ToList().ForEach(l => l.Idioma = "Português");

            return livros;
        }
    }
}
