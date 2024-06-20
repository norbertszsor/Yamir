using Yamir.Shared.Abstraction;

namespace Yamir.Transfer.Region.Command
{
    public class UpdateRegionCommand : ICommand
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public required string Country { get; set; }

        public string? Description { get; set; }

        public string? CountryCode { get; set; }
    }
}
