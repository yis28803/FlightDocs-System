using FlightDocs_System.Services.LoginLogout;
using FlightDocs_System.ViewModels.LoginLogout;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlightDocs_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountServices accountRepository;
        private readonly ILogger<AccountsController> logger;

        public AccountsController(IAccountServices accountRepository, ILogger<AccountsController> logger)
        {
            this.accountRepository = accountRepository;
            this.logger = logger;
        }

        [HttpPost("signup")]
        public async Task<IActionResult> SignUp([FromBody] SignUpAdmin model)
        {
            if (ModelState.IsValid)
            {
                var result = await accountRepository.SignUpAsync(model);
                if (result.Succeeded)
                {
                    return Ok(new { Message = "Đăng ký thành công!" });
                }
                else
                {
                    return BadRequest(new { Error = "Đăng ký không thành công", Errors = result.Errors });
                }
            }
            return BadRequest(new { Error = "Dữ liệu không hợp lệ" });
        }
        [HttpPost("signin")]
        public async Task<IActionResult> SignIn([FromBody] SignInModel signInModel)
        {
            if (ModelState.IsValid)
            {
                var token = await accountRepository.SignInAsync(signInModel);
                if (!string.IsNullOrEmpty(token))
                {
                    return Ok(new { Token = token });
                }
                else
                {
                    return Unauthorized(new { Error = "Đăng nhập không thành công" });
                }
            }
            return BadRequest(new { Error = "Dữ liệu không hợp lệ" });
        }

        [HttpPost("signout")]
        [Authorize]
        public async Task<IActionResult> SignOutAsync()
        {
            try
            {
                await accountRepository.SignOutAsync();
                return Ok(new { Message = "Đăng xuất thành công!" });
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return StatusCode(500, new { Error = "Đăng xuất mém thành công" });
            }
        }
    }
}
