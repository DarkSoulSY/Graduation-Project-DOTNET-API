using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fitness_Application.Models;
using Fitness_Application.Services.AccountService;

namespace Fitness_Application.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
            
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<Account>>> PostAccount(Account newAccount)
        {
            return Ok(await _accountService.PostAccount(newAccount));
        }
    }
}