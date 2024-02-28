using EmailSenderApp.Domain.Entites.Models.AuthModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSenderApp.Application.Services.AuthServices
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _configuration;

        public AuthService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<string> GeneratingToken(User user)
        {
            if (user == null)
            {
                return "Maybe user is null :(";
            }
            else if (user.Id != Guid.NewGuid())
            {
                return "User not found!";
            }

            if (UserExist(user))
            {
                var key = _configuration["JWT:Secret"];
            }
            else
            {
                return "User is UnAuthorized yet!";
            }

            throw new NotImplementedException();
        }

        private bool UserExist(User user) 
        {
            var login = "MyLogin111";
            var password = "MyPassword111";

            if(user.Login == login && user.Password == password)
            {
                return true;
            }

            return false;
        }
    }
}
