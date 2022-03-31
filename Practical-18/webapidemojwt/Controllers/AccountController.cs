using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapidemojwt.Models;
using webapidemojwt.Repository;

namespace webapidemojwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository accountRepository;

        public AccountController(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }
        [HttpPost("signup")]
        public async Task<IActionResult> SignUpUser([FromBody] SignUpModel signup)
        {
            var result = await accountRepository.SignUpAsync(signup);
            if(result.Succeeded)
            {
                return Ok(result.Succeeded);
            }
            return Unauthorized();
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] SignInModel login)
        {
            var result = await accountRepository.LoginAsync(login);
            if (string.IsNullOrEmpty(result))
            {
                return Unauthorized();
            }
            return Ok(result);
        }
    }
}
