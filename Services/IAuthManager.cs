using Colomb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colomb.Services
{
    public interface IAuthManager
    {
        // Validate user
        Task<bool> ValidateUser(CompteDTO userDTO);

        // Create and return the token
        Task<string> CreateToken();
    }
}
