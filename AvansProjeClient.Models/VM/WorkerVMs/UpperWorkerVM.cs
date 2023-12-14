using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansProjeClient.Models.VM.WorkerVMs
{
    public record UpperWorkerVM
    {
        public int WorkerID { get; set; }
        public string WorkerName { get; set; }
    }
}
