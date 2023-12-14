using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansProjeClient.Models.VM.WorkerVMs
{
    public record WorkerListVM
    {
        public string WorkerName { get; set; }
        public string WorkerEmail { get; set; }
        public string TitleName { get; set; }
        public string UnitName { get; set; }
        public string WorkerPhonenumber { get; set; }
    }
}
