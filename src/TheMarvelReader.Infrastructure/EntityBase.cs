namespace TheMarvelReader.Infrastructure
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}