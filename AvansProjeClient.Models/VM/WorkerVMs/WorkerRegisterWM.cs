﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansProjeClient.Models.VM.WorkerVMs
{
    public record WorkerRegisterWM
    {
        public string WorkerName { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string WorkerEmail { get; set; }
        public string WorkerPhonenumber { get; set; }
        public int TitleID { get; set; }
        public int UnitID { get; set; }
        public int UpperWorkerID { get; set; }
    }
}
