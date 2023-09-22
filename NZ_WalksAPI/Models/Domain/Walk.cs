namespace NZ_WalksAPI.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public string? WalkImageUrl { get; set; }
    }
}
