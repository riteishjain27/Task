using Assignment.InfraStructure.Business;
using Assignment.Models;

namespace Assignment.InfraStructure.Service
{
    public class UserService : IUserService
    {
        private readonly IUserBusiness _userBusiness;

        public UserService(IUserBusiness userBusiness)
        {
            this._userBusiness = userBusiness;
        }

        public UserDetail GetUserDetail(string userName)
        {
            var model = this._userBusiness.GetUserDetail(userName);

            return model;
        }


    }
}