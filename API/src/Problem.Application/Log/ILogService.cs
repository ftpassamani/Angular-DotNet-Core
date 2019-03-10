using Problem.Application.Log.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Problem.Application.Log
{
    public interface ILogService
    {
        Task<IEnumerable<LogAcessoOutput>> GetLogsAcessoAsync(string login);

        Task<LogAcessoOutput> CreateLogAcessoAsync(LogAcessoInput input);
    }
}
