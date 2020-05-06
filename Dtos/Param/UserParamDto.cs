using System.Text.Json.Serialization;

namespace PixForce.Dtos.Param
{
  public class UserParamDto
    {
        [JsonIgnore] //A chave(ID) é sempre passada na URL do método API.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}