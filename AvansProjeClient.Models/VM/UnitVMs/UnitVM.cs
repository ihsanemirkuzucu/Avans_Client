using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansProjeClient.Models.VM.UnitVMs
{
    public record UnitVM
    {
        public int UnitID { get; set; }
        public string UnitName { get; set; }
    }
}
