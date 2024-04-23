namespace E_Sport_1A2.Models
{
    public class Team
    {

        public int id { get; set; }
        public string name { get; set; }
            public int playersCount { get; set; }
            public Player[] players { get; set; }
            public int playedGames { get; set; }
            public int won { get; set; }
            public string currentRank { get; set; }
        
        
    }
}
