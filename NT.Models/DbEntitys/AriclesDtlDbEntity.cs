using System;
using System.Collections.Generic;
using System.Text;

namespace NT.Models.DbEntitys
{
    [Serializable]
    public class AriclesDtlDbEntity
    {
        public string ArticleDtlId { get; set; }
        public string ArticleId { get; set; }
        public int DtlType { get; set; }
        public string UserId { get; set; }
        public string ParentUserId { get; set; }
        public string Content { get; set; }
        public string ResouceId { get; set; }
        public int Status { get; set; }
        public string Memo { get; set; }
        public DateTime CreateTime { get; set; }
        public string CreateUser { get; set; }
        public DateTime UpdateTime { get; set; }
        public string UpdateUser { get; set; }
    }
}
