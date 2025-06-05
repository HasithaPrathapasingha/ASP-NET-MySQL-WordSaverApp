namespace WordSaverApp.Models
{
    public class WordEntry
    {
        public int Id { get; set; }
        public required string Word { get; set; }
        public required string Description { get; set; }  // <-- New input
        public DateOnly Date { get; set; }
    }
}
