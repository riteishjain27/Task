using Assignment.Models;
using RestSharp;
using System.Collections.Generic;

namespace Assignment.InfraStructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly RestClient _client;
        public UserRepository()
        {
            _client = new RestClient("https://api.github.com/");

        }
        public UserDetail GetUserDetail(string userName)
        {
            var userRequest = new RestRequest("users/" + userName, Method.GET);

            var userResponse = this._client.Execute<UserDetail>(userRequest);

            return userResponse.Data;
        }

        public List<UserRepos> GetUserRepos(string userName)
        {

            var userRepoRequest = new RestRequest("users/" + userName + "/repos", Method.GET);

            var userRepoResponse = this._client.Execute<List<UserRepos>>(userRepoRequest);

            return userRepoResponse.Data;
        }
    }

}