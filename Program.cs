using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegExSongT
{
    class Program
    {
        private static int songMatcher(string pfad, string regex)
        {
            int anzahl = 0;
            using (StreamReader reader = new StreamReader(pfad))
            {
                string zeile;
                Regex rx = new Regex("ein");
                while ((zeile = reader.ReadLine()) != null)
                {
                    MatchCollection matchCollection = rx.Matches(zeile);
                    //   System.Diagnostics.Debug.WriteLine(matchCollection.Count);
                    // foreach (Match item in matchCollection)
                    // {
                    //output += $"{item}";
                    // }
                }
            }
                            return anzahl;
        }
            static void Main(string[] args)
            {
                string pfad = "../../daten.txt";

            // nimm das Code-snippet und mache eine Funktion daraus (am besten übergibst Du nur den String der Regular Expression) 
            // und dann:

            // Zähle folgende Strings in der Datei:
            // bar
            // Bar
            // bar oder Bar
            System.Diagnostics.Debug.WriteLine( songMatcher(pfad, "bar"));
                       
            System.Diagnostics.Debug.WriteLine(songMatcher(pfad, "Bar"));


                        // alive
                        // Alive
                        // alive oder Alive

                        // alle Zeilen die entweder
                        // You got me rockin and a-rollin
                        // oder 
                        //Rockin and a - reelin

                        // "brother" oder "mother" aber sonst nichts

                        // evolution ohne ein "r" davor

                        // "you" oder "you're" aber kein "your"  

                        // know am Ende einer Zeile

                        // wieviele Worte beginnen mit jedem buchstaben des Alphabets- daher Anzahl aller *Worte* die mit "a" beginnen (case-insensitive), b, c, d ...

                        // komplizierter: gib die Zeilen aus die 
                        // Bands und Liedertitle enthalten
                        // nur die Bands
                        // nur die Liedertitel
                        // die Anzahl der Zeilen jedes Liedtitles
                



            }
    }
}
