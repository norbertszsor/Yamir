using Yamir.Shared.Abstraction;
using Yamir.Transfer.Region.Data;

namespace Yamir.Transfer.Region.Command
{
    public class CreateRegionCommand : ICommand<RegionDto>
    {
        public required string Name { get; set; }

        public required string Country { get; set; }

        public string? Description { get; set; }

        public string? CountryCode { get; set; }
    }
}
