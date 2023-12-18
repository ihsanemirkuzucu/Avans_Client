using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansProjeClient.Models.VM.AdvanceVMs
{
    public record AdvanceApproveStatusUpdate
    {
        public int AdvanceID { get; set; }
        public int ApproverOrRejecterID { get; set; }
        public decimal ApprovedAmount { get; set; }
    }
}
