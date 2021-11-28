using System;
using System.Collections.Generic;

namespace WebApplication1.Dal.Models
{
    public partial class CustomerSetting
    {
        public string CustomerId { get; set; } = null!;
        public string Setting { get; set; } = null!;

        public virtual Customer Customer { get; set; } = null!;
    }
}
