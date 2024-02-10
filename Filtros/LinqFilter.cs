namespace GY.Filtros
{
    using GY.Modelos;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class LinqFilter
    {
        public static void FiltrarGeneros(List<Musica> musicas)
        {
            var GenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
            foreach (var genero in GenerosMusicais)
            {
                Console.WriteLine($"- {genero}");
            }
        }

        public static void FiltrarArtistaPorGenero(List<Musica> musicas, string genero)
        {
            var ArtistaPorGenero = musicas
                .Where(musicas => musicas.Genero!.Contains(genero))
                .Select(musica => musica.Artista)
                .Distinct()
                .ToList();
            Console.WriteLine($"Exibindo os Artistas por genero >>> {genero}");
            foreach (var artista in ArtistaPorGenero)
            {
                Console.WriteLine($"- {artista}");
            }
        }

        public static void FiltrarMusicaDeUmArtista(List<Musica> musicas, string nomeDoArtista)
        {
            var MusicaPorArtista = musicas
                .Where(musica => musica.Artista!.Equals(nomeDoArtista))
                .ToList();
            Console.WriteLine(nomeDoArtista);
            foreach (var musica in MusicaPorArtista)
            {
                Console.WriteLine($"- {musica.Nome}");
            }
        }

        public static void FiltrarMusicasCsharp(List<Musica> musicas)
        {
            var MusicasCsharp = musicas
                .Where(musica => musica.Tonalidade.Equals("C#"))
                .Select(musica => musica.Nome)
                .ToList();
            Console.WriteLine("Músicas em C#: ");
            foreach (var musica in MusicasCsharp)
            {
                Console.WriteLine($" - {musica}");
            }
        }
    }
}
