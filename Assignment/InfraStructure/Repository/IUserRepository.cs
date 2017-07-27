using System.Collections.Generic;
using Assignment.Models;

namespace Assignment.InfraStructure.Repository
{
    public interface IUserRepository
    {
        UserDetail GetUserDetail(string userName);
        List<UserRepos> GetUserRepos(string userName);
    }
  
}
