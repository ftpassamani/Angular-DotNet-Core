using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Problem.Application.Log;
using Problem.Application.Log.Dto;
using Problem.Web.Core.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Problem.Web.Api.Controller.Log
{
    public class LogController : BaseController
    {
        
        private readonly ILogService _logService;

        public LogController(
            ILogService logService)
        {
            _logService = logService;
        }
        
        [HttpGet("[action]")]
        [Authorize]
        public async Task<ActionResult<LogAcessoOutput>> GetLogsAcesso(string login)
        {
            var getUserForCreateOrUpdateOutput = await _logService.GetLogsAcessoAsync(login);

            return Ok(getUserForCreateOrUpdateOutput);
        }
    }
}
