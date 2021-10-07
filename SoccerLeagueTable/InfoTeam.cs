namespace SoccerLeagueTable
{
    public class InfoTeam
    {
        private readonly string _name;
        private readonly int _for;
        private readonly int _against;

        public InfoTeam(string name, int @for, int against)
        {
            _name = name;
            _for = @for;
            _against = against;
        }
        public string Name => _name;
        public int For => _for;
        public int Against => _against;

    }
}