using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Project12_JwtToken.JWT
{
	public class TokenGenerator
	{
		public string GenerateJwtToken(string username)
		{
			var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("My20c#Projects+~/123!tokenJWTlongerKey"));
			var credantials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
			var claimsExample = new[]
			{
				new Claim(JwtRegisteredClaimNames.Sub,username),
				new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString())
			};
			var token = new JwtSecurityToken(
				issuer: "localhost",
				audience: "localhost",
				claims: claimsExample,
				expires: DateTime.Now.AddMinutes(5),
				signingCredentials: credantials);
			return new JwtSecurityTokenHandler().WriteToken(token);
		}
	}
}
