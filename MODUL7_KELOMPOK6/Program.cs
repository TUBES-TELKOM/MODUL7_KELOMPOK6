using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using MODUL7_KELOMPOK6;

namespace TP_MODUL7_KELOMPOK6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WatchList wl = new WatchList();
            wl.ReadJson();

        }
    }
}