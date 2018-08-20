using System.Collections.Generic;

namespace SPA.Models
{
    public interface ISrvP
    {
        int Id { get; set; }
        List<string> ServiceProviders { get; set; }
    }
}