using finalsolution.Model;
using System.Threading.Tasks;

namespace finalsolution.Application
{
    public interface IUserService
    {
        Task<UserModel> GetUser(int id);
    }
}