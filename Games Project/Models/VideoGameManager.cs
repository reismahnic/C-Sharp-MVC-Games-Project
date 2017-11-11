using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Games_Project.Models
{
    public class VideoGameManager
    {
        public static List<VideoGame> GetVideoGames()
        {
            return new List<VideoGame>
            {
                new VideoGame {VideoGameID=1, GameTitle="Nier", Developer="Cavia", ReleaseYear=2010, Characters= new List<Character> { new Character { CharacterID = 1, Name="Nier"}, new Character { CharacterID = 2, Name = "Kaine" }, new Character { CharacterID = 3, Name = "Emil" } } },
                new VideoGame {VideoGameID=2, GameTitle="Night in the Woods", Developer="Infinite Fall", ReleaseYear=2017, Characters= new List<Character> { new Character { CharacterID = 1, Name="Mae Borowski"}, new Character { CharacterID = 2, Name = "Gregg Lee" }, new Character { CharacterID = 3, Name = "Bea Santello" } } },
                new VideoGame {VideoGameID=3, GameTitle="Grim Fandango", Developer="Lucasarts", ReleaseYear=1998, Characters= new List<Character> { new Character { CharacterID = 1, Name="Manny Calavera"}, new Character { CharacterID = 2, Name = "Meche Colomar" }, new Character { CharacterID = 3, Name = "Glottis" } } }
            };
        }
    }
    public class VideoGame
    {
        public int VideoGameID { get; set; }
        public string GameTitle { get; set; }
        public string Developer { get; set; }
        public int ReleaseYear { get; set; }
        public List<Character> Characters { get; set; }
    }
          
    public class Character
    {
        public int CharacterID { get; set; }
        public string Name { get; set; }
    }
}