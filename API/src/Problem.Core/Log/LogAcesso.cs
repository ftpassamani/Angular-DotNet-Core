using System;
using System.Collections.Generic;
using System.Text;

namespace Problem.Core.Log
{
    public class LogAcesso : BaseEntity
    {
        public string Login { get; set; }
        public DateTime DataTentativa { get; set; }
        public bool Success { get; set; }
    }
}
