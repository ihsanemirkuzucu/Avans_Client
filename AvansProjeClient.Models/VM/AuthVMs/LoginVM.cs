using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansProjeClient.Models.VM.AuthVMs
{
    public record LoginVM
    {
        public string WorkerEmail { get; set; }
        public string WorkerName { get; set; }
        public string Password { get; set; }
        public int TitleID { get; set; }
        public string TitleName { get; set; }
        public string Token { get; set; }
    }
}
