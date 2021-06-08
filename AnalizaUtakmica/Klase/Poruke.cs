using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizaUtakmica.Klase
{
    public class Poruke
    {
        public static string PraznoPolje { get; set; } = "Polje je prezno!";
        public static string DodanaUtakmica { get; set; } = "Uspjesno ste dodali novu utakmicu!";
        public static string UpdateUtakmica { get; set; } = "Uspjesno ste updateovali odabranu utakmicu!";
        public static string RemoveTrUpit { get; set; } = "Da li ste sigurni da zelite izbrisati trening?";
        public static string RemoveUtakUpit { get; set; } = "Da li ste sigurni da zelite izbrisati utakmicu?";
        public static string RemoveSasUpit { get; set; } = "Da li ste sigurni da zelite izbrisati sastanak?";
        public static string RemoveAktUpit { get; set; } = "Da li ste sigurni da zelite izbrisati dodatnu aktivnost?";


    }
}
