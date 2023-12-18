using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansProjeClient.Models.VM.AdvanceVMs
{
    public record AdvanceAddVM
    {
        public int WorkerID { get; set; }
        public decimal AdvanceAmount { get; set; }
        public string? AdvanceExplanation { get; set; }
        public DateTime? RequestDate { get; set; }
        public int ProjectID { get; set; }
    }
}
