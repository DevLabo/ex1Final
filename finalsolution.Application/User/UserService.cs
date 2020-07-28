using finalsolution.Database;
using finalsolution.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace finalsolution.Application
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserModel> GetUser(int id)
        {
            return await _userRepository.GetUserModel(id);
        }
    }
}
