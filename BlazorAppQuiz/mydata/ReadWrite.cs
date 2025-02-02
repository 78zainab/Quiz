using Newtonsoft.Json;

namespace TestProect.mydata
{
    public class ReadWrite
    {
        public class UsersContainer
        {
            public List<User>? Users { get; set; }
        }
        public List<User> GetUser()
        {
            var jsonData = System.IO.File.ReadAllText("mydata/user.json");
            if (string.IsNullOrWhiteSpace(jsonData)) return null;

            // Deserialize to a UsersContainer which contains the List<User>
            var usersContainer = JsonConvert.DeserializeObject<UsersContainer>(jsonData);
            if (usersContainer == null || usersContainer.Users == null || usersContainer.Users.Count == 0)
                return null;

            return usersContainer.Users;
        }
    }
}
