using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicLINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //=========================================================
            //Solve all of the prompts below using various LINQ queries
            //=========================================================

            //=========================================================
            //There is only one artist in this collection from Mount 
            //Vernon. What is their name and age?
            //=========================================================

            //=========================================================
            //Who is the youngest artist in our collection of artists?
            //=========================================================

            //=========================================================
            //Display all artists with 'William' somewhere in their 
            //real name        
            //=========================================================

            //=========================================================
            //Display all groups with names less than 8 characters
            //=========================================================

            //=========================================================
            //Display the 3 oldest artists from Atlanta
            //=========================================================
            
            //=========================================================
            //(Optional) Display the Group Name of all groups that have 
            //at least one member not from New York City
            //=========================================================

            //=========================================================
            //(Optional) Display the artist names of all members of the 
            //group 'Wu-Tang Clan'
            //=========================================================
        }
    }
}
