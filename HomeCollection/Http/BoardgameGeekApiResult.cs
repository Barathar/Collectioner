namespace HomeCollection.Http
{
    public class BoardgameGeekApiResult
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Year { get; private set; }

        public BoardgameGeekApiResult(int id, string name, int year)
        {
            Id = id;
            Name = name;
            Year = year;
        }
    }
}
