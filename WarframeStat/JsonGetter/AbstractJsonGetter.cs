using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarframeStat.Statistics;

namespace WarframeStat.JsonGetter
{
    /// <summary>
    /// Abstract class for getting Warframe json
    /// </summary>
    public abstract class AbstractJsonGetter
    {
        /// <summary>
        /// Gets a Mainstat object.
        /// </summary>
        /// <returns></returns>
        public abstract MainStat GetMainStat();
    }
}
