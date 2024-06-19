using System.ComponentModel.DataAnnotations;
using Yamir.Shared.Abstraction;
using Yamir.Transfer.Tree.Data;

namespace Yamir.Transfer.Tree.Query
{
    public class GetTreeQuery : IQuery<TreeDto>
    {
        [Required]
        public Guid Id { get; set; }
    }
}
