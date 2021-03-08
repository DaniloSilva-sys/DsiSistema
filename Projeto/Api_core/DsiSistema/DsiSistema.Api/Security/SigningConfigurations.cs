using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace DsiSistema.Api.Security
{
    public class SigningConfigurations
    {
        private const string SECRETKEY = "54b4d79b-7fa5-11eb-99b9-021029b9431e";
        public SigningCredentials SigningCredentials { get; set; }
        private readonly SymmetricSecurityKey _securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SECRETKEY));
        public SigningConfigurations()
        {
            SigningCredentials = new SigningCredentials(_securityKey, SecurityAlgorithms.HmacSha512);
        }
    }
}