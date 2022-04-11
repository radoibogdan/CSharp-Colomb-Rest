using AutoMapper;
using Colomb.Data;
using Colomb.Models;
/*using Colomb.Services;*/
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colomb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<Compte> _userManager;
        private readonly ILogger<AccountController> _logger;
        private readonly IMapper _mapper;
        /*private readonly IAuthManager _authManager;*/
        public AccountController(UserManager<Compte> userManager,
            ILogger<AccountController> logger,
            IMapper mapper
            /*IAuthManager authManager*/)
        {
            _userManager = userManager;
            _logger = logger;
            _mapper = mapper;
            /*_authManager = authManager;*/
        }

        [HttpPost]
        [Route("register")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Register([FromBody] CompteDTO compteDTO)
        {
            _logger.LogInformation($"Enregistrement pour commencé {compteDTO.Email}");
            // Verify form
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                // Maps compteDTO into ApiUser fields
                var user = _mapper.Map<Compte>(compteDTO);
                user.UserName = compteDTO.Email;
                // Create User, gets password and hashes and stores it 
                var result = await _userManager.CreateAsync(user, compteDTO.Password);

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                    return BadRequest(ModelState);
                }
                await _userManager.AddToRolesAsync(user, compteDTO.Roles);
                return Accepted(); // 200 code
            }
            catch (Exception ex)
            {
                // Log information
                _logger.LogError(ex, $"Something went wrong in the {nameof(Register)}");
                // Return Error - var 1
                return Problem($"Something went wrong in the {nameof(Register)}", statusCode: 500);
                // Return Error - var 2
                // return StatusCode(500, $"Something went wrong in the {nameof(Register)}");
            }
        }

        [HttpPost]
        [Route("login")] // api/Compte/login
        public async Task<IActionResult> Login([FromBody] LoginCompteDTO compteDTO)
        {
            _logger.LogInformation($"Login Attemp form {compteDTO.Email}");
            // Verify form
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                if (!await _authManager.ValidateUser(compteDTO))
                {
                    return Unauthorized(); // 401 code
                }
                return Accepted(new { Token = await _authManager.CreateToken() }); // 200 code
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(Login)}");
                return Problem($"Something went wrong in the {nameof(Login)}", statusCode: 500);
            }
        }
    }
}
