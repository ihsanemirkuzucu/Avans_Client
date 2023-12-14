using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvansProjeClient.Models.VM.TitleVMs;
using AvansProjeClient.Models.VM.UnitVMs;
using AvansProjeClient.Models.VM.WorkerVMs;

namespace AvansProjeClient.Models.VM.AuthVMs
{
    public record RequiredDataVM
    {
        public List<UnitVM> Unit { get; set; }
        public List<TitleVM> Title { get; set; }
        public List<UpperWorkerVM> Worker { get; set; }
    }
}
