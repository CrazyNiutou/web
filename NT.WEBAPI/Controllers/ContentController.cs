using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NT.Common;
using NT.IBusiness;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NT.WEBAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ContentController : Controller
    {
        private IContent _content;

        public ContentController(IContent content)
        {
            _content = content;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{articleType}")]
        [EnableCors("CorsCore")]//定义跨域
        public string GetArticleList(int articleType)
        {
            var result = _content.GetArticleList(articleType);
            if (result == null && result.Count <= 0)
            {
                return null;
            }
            var json = result.JsonSerializeObjectShortDate();
            return json;
        }
        [HttpGet("{articleId}")]
        [EnableCors("CorsCore")]//定义跨域
        public string GetArticleDtl(string articleId)
        {
            var result = _content.GetArticleDetail(articleId);
            if (result == null || result.Count <= 0)
            {
                return null;
            }
            var json = result.JsonSerializeObjectShortDate();
            return json;
        }
        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
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