using Assignment.Models;

namespace Assignment.InfraStructure.Service
{
    public interface IUserService
    {
        UserDetail GetUserDetail(string userName);

    }
}
