using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace MODUL7_KELOMPOK6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Membaca dan menampilkan data dari JSON untuk Film Favorit
            Console.WriteLine("=== Film Favorit ===");
            FilmFavorit_103022400110.ReadJSON("");
            
            // Membaca dan menampilkan data dari JSON untuk Watchlist
            Console.WriteLine("=== Watchlist ===");
            Watchlist_103022400110 w1 = new Watchlist_103022400110();
            //w1.ReadJSON();
            
            // Membaca dan menampilkan data dari JSON untuk Genre Dictionary
            Console.WriteLine("=== Genre Dictionary ===");
            GenreDictionary_103022400110 gd = new GenreDictionary_103022400110();
            gd.ReadJSON();
        }
    }
}