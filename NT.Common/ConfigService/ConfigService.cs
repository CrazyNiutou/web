using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace NT.Common
{
    public class ConfigService
    {
        public readonly ConfigOptions m_ConfigOptions;
        public ConfigService(IOptions<ConfigOptions> options)
        {
            m_ConfigOptions = options.Value;
        }
    }
}
