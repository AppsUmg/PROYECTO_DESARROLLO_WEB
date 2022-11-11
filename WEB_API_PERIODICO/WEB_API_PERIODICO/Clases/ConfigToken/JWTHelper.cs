using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WEB_API_PERIODICO.Clases.ConfigToken
{
    public class JWTHelper
    {
        private readonly byte[] secret = Encoding.ASCII.GetBytes("ADXSADSAD-SADSADASDASD-DSADSADSADSAX");

        public string CrearToken(ClsRespuestaLogin ClsRespuestaLogin)
        {


            var claims = new ClaimsIdentity();
            claims.AddClaim(new Claim(ClaimTypes.NameIdentifier, ClsRespuestaLogin.Usuario));
            //claims.AddClaim(new Claim(ClaimTypes.GivenName, "VISITANTE"));
            claims.AddClaim(new Claim(ClaimTypes.Role, ClsRespuestaLogin.Rol));
            claims.AddClaim(new Claim(ClaimTypes.Role, "VISITANTE"));
            //for (int i = 0; i < 5; i++)
            //{
            //    claims.AddClaim(new Claim(ClaimTypes.Role, "visitante" + i));
            //}


            var tokenDescription = new SecurityTokenDescriptor()
            {
                Subject = claims,
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secret), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var createdToken = tokenHandler.CreateToken(tokenDescription);

            return tokenHandler.WriteToken(createdToken);

        }

    }
}
