using finalsolution.Domain;
using finalsolution.Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalsolution.Database
{
    public class UserRepository : Repository<User, Context>, IUserRepository
    {
        public UserRepository(Context context) :
            base(context) { }

        public async Task<UserModel> GetUserModel(int id)
        {
            var list = await GetAll();
            return list.AsQueryable().Where(u => u.Id == id).Select(UserExpression.Model).FirstOrDefault();
        }
    }
}
