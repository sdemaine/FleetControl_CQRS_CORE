using AutoMapper;
using FleetControl.Persistence.Identity;
using FleetControl.WebUI.Extensions;
using FleetControl.WebUI.Helpers;
using FleetControl.WebUI.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetControl.WebUI.Controllers
{
    public class AccountController : BaseController
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signinManager;
        private readonly IMapper _mapper;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signinManager, IMapper mapper)
        {
            _userManager = userManager;
            _signinManager = signinManager;
            _mapper = mapper;
        }
        public async Task<IActionResult> Register()
        {
            var userManager = _userManager;
            var signinManager = _signinManager;

            return await Task.Run(() => Ok());
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody]RegistrationViewModel model)
        {
            
            if (!ModelState.IsValid)
            {
                return await Task.Run(() => Ok(ModelState.Errors()));
            }

            var userIdentity = _mapper.Map<ApplicationUser>(model);

            // var identityUser2 = new ApplicationUser() { Email = model.Email, UserName = model.Email };
            var result = await _userManager.CreateAsync(userIdentity, model.Password);
            if (!result.Succeeded)
            {
                return await Task.Run(() => Ok(result.Errors));
            }

            await _signinManager.SignInAsync(userIdentity, isPersistent: false);

            return await Task.Run(() => Ok("Account created"));
        }
    }
}