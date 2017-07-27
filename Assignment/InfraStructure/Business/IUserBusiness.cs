using Assignment.Models;

namespace Assignment.InfraStructure.Business
{
    public interface IUserBusiness
    {
        UserDetail GetUserDetail(string userName);
    }
}
