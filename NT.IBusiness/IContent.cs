using NT.Models.Db.Serialize;
using System;
using System.Collections.Generic;
using System.Text;

namespace NT.IBusiness
{
    public interface IContent
    {
        List<ArticleListSerialize> GetArticleList(int articleType);
        List<ArticleDetailSerialize> GetArticleDetail(string articleId);
    }
}
