using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeStat.JsonGetter
{
    public class JsonGetterFactory
    {
        /// <summary>
        /// Gets a JsonGetter object that fits the gettertype argument.
        /// </summary>
        /// <param name="getterType"></param>
        /// <returns></returns>
        public AbstractJsonGetter GetJsonGetter(JsonGetterType getterType)
        {
            switch (getterType)
            {
                case JsonGetterType.FromWarframeStat:
                    
                    break;
                default:
                    break;
            }
        }
    }

    public enum JsonGetterType
    {
        /// <summary>
        /// Get a JsonGetter object that fetches the statistics from http://ws.warframestat.us/pc
        /// </summary>
        FromWarframeStat
    }
}
