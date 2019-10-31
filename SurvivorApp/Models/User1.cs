using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
 

 namespace Survivor.Models
 {
     public class User1
     {
        public int User1Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public ICollection<Player> Players {get;set;}
        public ICollection<Season> Seasons { get; set; }
        public User1()
        {
            this.Players = new HashSet<Player> () ;
            this.Seasons = new HashSet<Season> () ;
        }

        public static User1 GetUsers(User1 user)
        {
            var apiCallTask = ApiHelper.AuthApiCall(user);
            var result = apiCallTask.Result;

            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
            User1 userLogin = JsonConvert.DeserializeObject<User1>(jsonResponse.ToString());

            return userLogin;
        }
        public static void CreateUser(User1 newUser)
        {
            var apiCallTask = ApiHelper.NewUserApiCall(newUser);
            var result = apiCallTask.Result;

        }
        
     }
 }