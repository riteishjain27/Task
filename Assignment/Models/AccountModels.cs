using System.Collections.Generic;

namespace Assignment.Models
{
    public class UserDetail
    {
        public string login { get; set; }
        public string location { get; set; }
        public string avatar_url { get; set; }
        public List<UserRepos> detail { get; set; }
    }
    public class UserRepos
    {
        public int id { get; set; }
        public string name { get; set; }
        public int stargazers_count { get; set; }
    }

}
