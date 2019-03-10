using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Problem.Application.Log.Dto;
using Problem.Core.Log;
using Problem.EntityFramework;

namespace Problem.Application.Log
{
    public class LogService : ILogService
    {
        private readonly ProblemDbContext _dbContext;
        private readonly IMapper _mapper;
        public LogService(
          ProblemDbContext dbContext,
            IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<LogAcessoOutput> CreateLogAcessoAsync(LogAcessoInput input)
        {
            var logAcesso = new LogAcesso()
            {
                Login = input.Login,
                DataTentativa = DateTime.Now,
                Success = input.Success,
                CreateDate = DateTime.Now
            };

            _dbContext.LogAcessos.Add(logAcesso);

            return new LogAcessoOutput()
            {
                Id = logAcesso.Id
            };
        }

        public async Task<IEnumerable<LogAcessoOutput>> GetLogsAcessoAsync(string login)
        {
            IEnumerable<LogAcesso> logs = null;
            if (!string.IsNullOrEmpty(login))
                logs = _dbContext.LogAcessos.Where(p => p.Login == login).OrderBy(r => r.DataTentativa).ToList();
            else
                logs = _dbContext.LogAcessos.ToList();

            return _mapper.Map<IEnumerable<LogAcessoOutput>>(logs);
        }
    }
}
