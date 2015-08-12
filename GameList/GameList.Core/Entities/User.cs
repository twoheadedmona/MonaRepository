using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;


namespace GameList.Core.Entities
{
    public class User:Base
    {
        public string Username { get; set; }
        public string Password { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Bio { get; set; }
        public List<User> Friends { get; set; }
        public List<Game> Games { get; set; }
        public List<Studio> FavStudios { get; set; }
    }
}
