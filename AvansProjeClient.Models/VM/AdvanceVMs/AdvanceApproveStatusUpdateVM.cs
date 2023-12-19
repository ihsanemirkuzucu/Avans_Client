using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansProjeClient.Models.VM.AdvanceVMs
{
    public record AdvanceApproveStatusUpdateVM
    {
        public int AdvanceID { get; set; }
        public int ApproverOrRejecterID { get; set; }
        public decimal ApprovedAmount { get; set; }
        public DateTime DeterminedAdvanceDate { get; set; }
        public int ApproveAdvanceStatusID { get; set; }
    }
}
