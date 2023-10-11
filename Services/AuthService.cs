using Database.Entities;
using Microsoft.AspNetCore.Identity;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Services;

namespace Services
{
    public class AuthService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public async Task CreateUserWithHashedPasswordAsync(string email, string password)
        {
            var user = new User { Email = email };
            var result = await _userManager.CreateAsync(user, password);
            if (result.Succeeded)
            {

            }
        }

        public async Task<bool> SignInWithPasswordAsync(string email, string password)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user != null)
            {
                var result = await _signInManager.CheckPasswordSignInAsync(user, password, false);

                if (result.Succeeded)
                {
                    return true;
                }
            }

            return false;
        }

    }

}
