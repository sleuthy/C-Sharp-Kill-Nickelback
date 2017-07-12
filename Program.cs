using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
        // Define a List, named goodSongs, that will hold tuples consisting of two strings.
        // The name of an artist
        // A song by that artist
        // // Example
        // HashSet<(string, string)> songs = new HashSet<(string, string)>();
        // Make sure that some of the songs are from the band Nickelback. You can see a list of their greatest hits on Amazon.
        List<(string song1, string song2)> goodSongs = new List<(string, string)>();

        // Define a HashSet, named allSongs, that contains 7 tuples. Each tuple should contain two string values:
         HashSet<(string, string)> allSongs = new HashSet<(string, string)>();

         allSongs.Add(("Nickelback", "Photographs"));
         allSongs.Add(("Nickelback", "Lullaby"));
         allSongs.Add(("Nickelback", "Animals"));
         allSongs.Add(("Madonna", "Vogue"));
         allSongs.Add(("Tori Amos", "China"));
         allSongs.Add(("Paula Cole", "Me"));
         allSongs.Add(("Paula Abdul", "Straight Up"));

         // List out artists with songs to make sure it works.
         Console.WriteLine("All songs:");
         foreach ((string, string) song in allSongs)
         {
             Console.WriteLine($"{song.Item1} : {song.Item2}");
         }

        // Once the set is populated with 7 tuples, iterate over the set of songs, and check if the band name is "Nickelback".
        // If the band is not Nickelback, then add it to the goodSongs list.
        foreach ((string, string) song in allSongs)
        {
            if (song.Item1 != "Nickelback"){
                goodSongs.Add(song);
            }
        }
        // Use another foreach loop to print out all the good songs.
        Console.WriteLine("Music that doesn't suck:");
        foreach ((string, string) item in goodSongs)
        {
            Console.WriteLine($"{item.Item1} : {item.Item2}");
        }
            
        }
    }
}

