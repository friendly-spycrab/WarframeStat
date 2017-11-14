﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarframeStat.MainStatGetter
{
    public class MainStatGetterFactory
    {
        /// <summary>
        /// Gets a JsonGetter object that fits the gettertype argument.
        /// </summary>
        /// <param name="getterType"></param>
        /// <returns></returns>
        public AbstractMainStatGetter GetJsonGetter(JsonGetterType getterType)
        {
            switch (getterType)
            {
                case JsonGetterType.FromWarframeStat:
                    return new WarframeMainStatGetter();
                default:
                    return null;
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