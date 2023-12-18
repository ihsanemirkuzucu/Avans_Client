using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansProjeClient.Models.VM.AdvanceVMs
{
    public record AdvanceDetailsVM
    {
        public AdvanceDetailVM AdvanceDetail { get; set; }
        public List<AdvanceHistoryVM> AdvanceHistoryList { get; set; }
    }
}
