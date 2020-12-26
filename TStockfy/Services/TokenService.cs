using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using TStockfy.JWT;
using TStockfy.Model;

namespace TStockfy.Services
{
    //public class TokenService
    //{
    //    public static string GenerateToken(Acesso acesso) {
    //        var tokenHandler = new JwtSecurityTokenHandler();
    //        var key = Encoding.ASCII.GetBytes(Settings.Secret);
    //        var tokenDescriptor = new SecurityTokenDescriptor();

    //        var lstClaim = new List<Claim>();

    //        lstClaim.Add(new Claim(ClaimTypes.Name, acesso.Nome.ToString()));
    //        lstClaim.Add(new Claim(ClaimTypes.Role, acesso.Role.ToString()));

    //        tokenDescriptor.Subject = new ClaimsIdentity(lstClaim);

    //        tokenDescriptor.Expires = DateTime.UtcNow.AddDays(7);
    //        tokenDescriptor.SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature);
    //        var token = tokenHandler.CreateToken(tokenDescriptor);
    //        return tokenHandler.WriteToken(token);

    //    }
    //}
}
