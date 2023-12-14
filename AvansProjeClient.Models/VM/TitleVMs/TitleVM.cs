using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansProjeClient.Models.VM.TitleVMs
{
    public record TitleVM
    {
        public int TitleID { get; set; }
        public string TitleName { get; set; }
    }
}
