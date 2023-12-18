using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvansProjeClient.Models.VM.ProjectVMs;

namespace AvansProjeClient.Models.VM.AdvanceVMs
{
    public record NewAdvanceRequired
    {
        public List<ProjectVM> Projects { get; set; }
    }
}

