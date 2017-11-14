using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarframeStat.Statistics;
using System.Net;
namespace WarframeStat.MainStatGetter
{
    public class WarframeMainStatGetter : AbstractMainStatGetter
    {
        /// <summary>
        /// Gets json from http://ws.warframestat.us/pc and converts it to a mainstat object
        /// </summary>
        /// <returns></returns>
        public override MainStat GetMainStat()
        {
            WebClient client = new WebClient();
            string Json = client.DownloadString("http://ws.warframestat.us/pc");
            return MainStat.FromJson(Json);
        }
    }
}
