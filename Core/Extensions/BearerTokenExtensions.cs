// Copyright © 2015 - Avanade Inc.

using System;
using System.Collections.Generic;
using System.IdentityModel.Protocols.WSTrust;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Security.Claims;
using Avanade.Amp.Core.Site;

namespace Avanade.Amp.Core.Extensions
{
    public static class BearerTokenExtensions
    {
        public static string GetSiteBearerToken(this SiteEntity site, string upn, IEnumerable<string> roles)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Upn, upn)
            };
            if (roles != null)
            {
                claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));
            }
            return claims.GetBearerToken("http://avanade-amp.net", site.EndpointName, site.EndpointSAS);
        }

        public static string GetBearerToken(this List<Claim> claims, string issuer, string audience, string base64Key)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            var now = DateTime.UtcNow;
            var std = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                TokenIssuerName = issuer,
                AppliesToAddress = audience,
                Lifetime = new Lifetime(now, now.AddMinutes(10)),
                SigningCredentials = new SigningCredentials(
                    new InMemorySymmetricSecurityKey(Convert.FromBase64String(base64Key)),
                    "http://www.w3.org/2001/04/xmldsig-more#hmac-sha256",
                    "http://www.w3.org/2001/04/xmlenc#sha256"),
            };
            var token = jwtTokenHandler.CreateToken(std);
            return jwtTokenHandler.WriteToken(token);
        }
    }
}