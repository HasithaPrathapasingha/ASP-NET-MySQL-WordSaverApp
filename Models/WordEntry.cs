namespace WordSaverApp.Models
{
    public class WordEntry
    {
        public int Id { get; set; }
        public required string Word { get; set; }
        public DateOnly Date { get; set; }
    }
}
