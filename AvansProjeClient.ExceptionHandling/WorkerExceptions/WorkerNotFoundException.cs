using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvansProjeClient.ExceptionHandling.WorkerExceptions
{
    public class WorkerNotFoundException : Exception
    {
        public WorkerNotFoundException() { }
        public WorkerNotFoundException(string message) : base(message) { }
        public WorkerNotFoundException(string message, Exception inner) : base(message, inner) { }
    }
}
