namespace MyPortfolio.DAL.Entites
{
    public class Message
    {
        public int Id { get; set; }
        public string NameSurName { get; set; }
        public string Subject { get; set;
        public string MessageDetail { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }

    }
}
