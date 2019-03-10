using Problem.Application.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem.Application.Log.Dto
{
    public class LogAcessoOutput : EntityDto
    {
        public string Login { get; set; }
        public DateTime DataTentativa { get; set; }
        public bool Success { get; set; }
    }
}
