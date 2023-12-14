using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansProjeClient.Models.VM.ProjectVMs
{
    public record ProjectVM
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
    }
}
