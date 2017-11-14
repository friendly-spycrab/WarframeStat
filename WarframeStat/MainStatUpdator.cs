using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarframeStat.Statistics;

namespace WarframeStat
{

    public class CetusCycleUpdatedEventArgs : EventArgs
    {
        public CetusCycle NewCycle;
    }

    public class MainStatUpdator
    {
        public event EventHandler<CetusCycleUpdatedEventArgs> CetusCycleUpdated;

        private MainStat stat;
        
        public MainStatUpdator(MainStat _stat)
        {
            stat = _stat;
        }

        public virtual void OnCetusCycleUpdated(CetusCycleUpdatedEventArgs args)
        {
            EventHandler<CetusCycleUpdatedEventArgs> handler = CetusCycleUpdated;
            handler?.Invoke(this,args);
        }


    }
}
