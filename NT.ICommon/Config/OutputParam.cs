using System;
using System.Collections.Generic;
using System.Text;

namespace NT.ICommon
{
    public class OutputParam
    {
        public int StatusCode { get; set; } = 200;
        public string ResultMsg { get; set; } = "";
        public string ErrMsg { get; set; } = "";
        public string Data { get; set; } = "";
        public string ReturlUrl { get; set; } = "";
    }
}
