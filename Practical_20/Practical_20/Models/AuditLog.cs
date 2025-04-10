namespace Practical_20.Models
{
    public class AuditLog
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Level { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
