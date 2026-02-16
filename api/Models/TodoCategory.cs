using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace api.Models
{
    public class TodoCategory
    {
        public Guid Id {get; set;} = Guid.NewGuid();
        public string Category { get; set; } = string.Empty;
    }
}