namespace VivesHelpdesk.Ui.WebApp.Models
{
    public class Ticket
    {
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Author { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
    }
}
