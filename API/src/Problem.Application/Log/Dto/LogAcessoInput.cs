using System;
using System.Collections.Generic;
using System.Text;

namespace Problem.Application.Log.Dto
{
    public class LogAcessoInput
    {
        public string Login { get; set; }
        public DateTime DataTentativa { get; set; }
        public bool Success { get; set; }
    }
}
