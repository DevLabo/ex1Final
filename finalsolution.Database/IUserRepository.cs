using finalsolution.Domain;
using finalsolution.Model;
using System.Threading.Tasks;

namespace finalsolution.Database
{
    public interface IUserRepository  : IRepository<User>
    {
        Task<UserModel> GetUserModel(int id);
    }
}
