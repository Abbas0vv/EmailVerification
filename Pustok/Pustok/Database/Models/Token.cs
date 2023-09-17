using Pustok.Database.Base;

namespace Pustok.Database.Models;

public class Token : BaseEntity<int>
{
    public string TokenCode { get; set; }
    User User { get; set; }
}
