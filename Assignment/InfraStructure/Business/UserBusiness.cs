using Assignment.InfraStructure.Repository;
using Assignment.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.InfraStructure.Business
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepository _userRepository;
        public UserBusiness(IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public UserDetail GetUserDetail(string userName)
        {
            var userDetailTask = Task.Factory.StartNew(() => this._userRepository.GetUserDetail(userName));

            var userRepoTask = Task.Factory.StartNew(() => this._userRepository.GetUserRepos(userName));

            var userRepo = userRepoTask.Result;

            var userDetail = userDetailTask.Result;

            if (userRepo != null)
            {
                userDetail.detail = userRepo.OrderByDescending(x => x.stargazers_count).Take(5).ToList();
            }

            return userDetail;
        }

    }

}