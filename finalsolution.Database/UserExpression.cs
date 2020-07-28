using finalsolution.Domain;
using finalsolution.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace finalsolution.Database
{
    public static class UserExpression
    {
        public static Expression<Func<User, UserModel>> Model => user => new UserModel
        {
            Email = user.Email,
            Name = user.Name
        };
    }
}
