using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace NT.WEBAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        [EnableCors("CorsCore")]//定义跨域
        public async Task<OkObjectResult> Get()
        {
            var test = new List<string>();
            test.AddRange(new string[] { "value1", "value2", "value3", "value4" });
            var result = JsonConvert.SerializeObject(test);

            var claims = new[]
            {
                new  Claim(ClaimTypes.Name,"admin")
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("dd%88*377f6d&f£$$£$FdddFF33fssDG^!3"));
            var credent = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //.NET Core’s JwtSecurityToken class takes on the heavy lifting and actually creates the token.
            /**
             * Claims (Payload)
                Claims 部分包含了一些跟这个 token 有关的重要信息。 JWT 标准规定了一些字段，下面节选一些字段:

                iss: The issuer of the token，token 是给谁的
                sub: The subject of the token，token 主题
                exp: Expiration Time。 token 过期时间，Unix 时间戳格式
                iat: Issued At。 token 创建时间， Unix 时间戳格式
                jti: JWT ID。针对当前 token 的唯一标识
                除了规定的字段外，可以包含其他任何 JSON 兼容的字段。
             * */
            var token = new JwtSecurityToken(
                 issuer: "test.com",
                 audience: "test.com",
                 claims: claims,
                 expires: DateTime.Now.AddMinutes(30),
                 signingCredentials: credent
                );

            return Ok(new JwtSecurityTokenHandler().WriteToken(token));

            //return new JsonResult(result);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
