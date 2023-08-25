namespace Test1.Shared.Domain
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
