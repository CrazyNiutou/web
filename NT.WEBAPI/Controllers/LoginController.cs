using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using NT.IBusiness;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NT.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        private IAccount _account;
        private ILogger _logger;
        public LoginController(IAccount account, ILogger<LoginController> logger)
        {
            _account = account;
            _logger = logger;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{userName,pwd}")]
        public IActionResult Get(string userName, string pwd)
        {
            return null;
        }


        // POST api/<controller>
        [HttpPost]
        public async Task<ObjectResult> Post([FromBody]dynamic obj)
        { 
            try
            {
                var userName = Convert.ToString(obj.userName);
                var pwd = Convert.ToString(obj.pwd);
                var result = await _account.GetUsersInfoAsync(userName, pwd);
                if (result == null || result.Result == null)
                {
                    return BadRequest("帐号或密码错误");
                }
                var claims = new[] { new Claim(ClaimTypes.Name, userName) };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("dd%88*377f6d&f£$$£$FdddFF33fssDG^!3"));
                var credent = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                //.NET Core’s JwtSecurityToken class takes on the heavy lifting and actually creates the token.
                /**  Claims (Payload)
                    Claims 部分包含了一些跟这个 token 有关的重要信息。 JWT 标准规定了一些字段，下面节选一些字段:
                    iss: The issuer of the token，token 是给谁的
                    sub: The subject of the token，token 主题
                    exp: Expiration Time。 token 过期时间，Unix 时间戳格式
                    iat: Issued At。 token 创建时间， Unix 时间戳格式
                    jti: JWT ID。针对当前 token 的唯一标识
                    除了规定的字段外，可以包含其他任何 JSON 兼容的字段。 * */
                var token = new JwtSecurityToken(
                     issuer: "test.com",
                     audience: "test.com",
                     claims: claims,
                     expires: DateTime.Now.AddMinutes(30),
                     signingCredentials: credent
                    );
                return Ok(new JwtSecurityTokenHandler().WriteToken(token));
            }
            catch (Exception ex)
            {
                return BadRequest("接口未知错误");
            }
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}