namespace AFS_TRANSLATOR.CORE
{
    public abstract class CoreEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}