using finalsolution.Model;
using finalsolution.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace finalsolution.Application
{
    public static class UserFactory
    {
        public static User Create (UserModel userModel)
        {
            return new User(
               userModel.Email,
               userModel.Name
            );
        }
    }
}
