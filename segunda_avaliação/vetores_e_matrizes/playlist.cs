using System;

class PlayList
{
    private string nome, descricao;
    private Musica[] musicas;
    private int numMusicas;

    public PlayList(string nome, string descricao)
    {
        if (!string.IsNullOrEmpty(nome)){
            this.nome = nome;
        }else {
            throw new ArgumentOutOfRangeException();
        }

        if (!string.IsNullOrEmpty(descricao)) {
            this.descricao = descricao;
        } else {
            throw new ArgumentOutOfRangeException();
        }

        musicas = new Musica[10]; // Definindo um limite de 10 músicas por playlist
        numMusicas = 0;
    }

    public void Inserir(Musica m)
    {
        if (numMusicas < musicas.Length)
        {
            musicas[numMusicas] = m;
            numMusicas++;
        }
        else
        {
            Console.WriteLine("A playlist está cheia. Não é possível adicionar mais músicas.");
        }
    }

    public Musica[] Listar()
    {
        Musica[] lista = new Musica[numMusicas];
        Array.Copy(musicas, lista, numMusicas);
        return lista;
    }

    public TimeSpan TempoTotal()
    {
        TimeSpan tempoTotal = TimeSpan.Zero;
        foreach (Musica m in musicas)
        {
            if (m != null)
            {
                tempoTotal += m.Duracao;
            }
        }
        return tempoTotal;
    }

    public override string ToString()
    {
        return $"{nome} | {descricao}";
    }
}

class Musica
{
    private string titulo, artista, album;
    private DateTime dataInclusao;
    private TimeSpan duracao;

    public Musica(string titulo, string artista, string album, DateTime dataInclusao, TimeSpan duracao)
    {
        if (!string.IsNullOrEmpty(titulo))
        {
            this.titulo = titulo;
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }

        if (!string.IsNullOrEmpty(artista))
        {
            this.artista = artista;
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }

        if (!string.IsNullOrEmpty(album))
        {
            this.album = album;
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }

        this.dataInclusao = dataInclusao;
        this.duracao = duracao;
    }

    public override string ToString()
    {
        return $"{titulo} | {artista} | {album} | {dataInclusao} | {duracao}";
    }

    public TimeSpan Duracao
    {
        get { return duracao; }
    }
}

class Program
{
    public static void Main()
    {
        PlayList playlist = new PlayList("Minha Playlist", "Uma playlist qualquer");

        Musica musica1 = new Musica("Título 1", "Artista 1", "Álbum 1", DateTime.Now, TimeSpan.FromMinutes(4));
        Musica musica2 = new Musica("Título 2", "Artista 2", "Álbum 2", DateTime.Now, TimeSpan.FromMinutes(3));
        Musica musica3 = new Musica("Título 3", "Artista 3", "Álbum 3", DateTime.Now, TimeSpan.FromMinutes(5));

        playlist.Inserir(musica1);
        playlist.Inserir(musica2);
        playlist.Inserir(musica3);

        Musica[] musicas = playlist.Listar();
        Console.WriteLine($"Músicas na playlist {playlist}:");
        foreach (Musica m in musicas)
        {
            Console.WriteLine(m);
        }

        TimeSpan tempoTotal = playlist.TempoTotal();
        Console.WriteLine($"Tempo total da playlist: {tempoTotal}");
    }
}