using System;
using System.Collections.Generic;
using System.Text;

namespace NT.Models.Db.Serialize
{
    public class ArticleListSerialize : ArticlesDbEntity
    {
        /// <summary>
        /// 更新人
        /// </summary>
        public string cName { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string bName { get; set; }
    }
}
