using EmailSenderApp.Domain.Entites.Models.AuthModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSenderApp.Application.Services.AuthServices
{
    public interface IAuthService
    {
        public Task<string> GeneratingToken(User user);

    }
}
