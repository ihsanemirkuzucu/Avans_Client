using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvansProjeClient.Models.VM.TitleVMs;
using AvansProjeClient.Models.VM.UnitVMs;

namespace AvansProjeClient.Models.VM.WorkerVMs
{
    public record WorkerVM
    {
        public int WorkerID { get; set; }

        public string WorkerName { get; set; }

        public string WorkerEmail { get; set; }

        public string WorkerPhonenumber { get; set; }

        public int? UnitID { get; set; }

        public int? TitleID { get; set; }

        public int? UpperWorkerID { get; set; }

        public virtual TitleVM Title { get; set; }

        public virtual UnitVM Unit { get; set; }

        public virtual WorkerVM Worker2 { get; set; }
    }
}
