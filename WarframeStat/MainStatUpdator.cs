using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using WarframeStat.Statistics;
using System.Windows.Threading;

namespace WarframeStat
{

    /// <summary>
    /// Event arguments for an updated cetus cycle
    /// </summary>
    public class CetusCycleUpdatedEventArgs : EventArgs
    {
        public CetusCycle NewCycle;
    }

    /// <summary>
    /// Main class for updating a MainStat class
    /// </summary>
    public class MainStatUpdator
    {
        public event EventHandler<CetusCycleUpdatedEventArgs> CetusCycleUpdated;

        private MainStat stat;
        
        public MainStatUpdator(MainStat _stat)
        {
            stat = _stat;
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(UpdateStat);
            dispatcherTimer.Interval = new TimeSpan(0,0,1);
            dispatcherTimer.Start();
        }

        private void UpdateStat(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Returns an updated cetuscycle object
        /// </summary>
        /// <param name="cycle"></param>
        /// <param name="TimeAmountChanged">Amount of time that has gone by since the last update</param>
        /// <returns></returns>
        private CetusCycle UpdateCetusCycle(CetusCycle cycle,TimeSpan TimeAmountChanged)
        {
            
        }

        /// <summary>
        /// Converts the time left string to a timespan
        /// </summary>
        /// <param name="Time"></param>
        /// <returns></returns>
        private TimeSpan ToTimeSpan(string Time)
        {
            int Second = 0;
            int Minute = 0;
            int Hour = 0;

            foreach (var item in Time.Split(' '))
            {
                if (item.Contains("s"))
                    Second = int.Parse(item);
                else if (item.Contains("m"))
                    Minute = int.Parse(item);
                else if(item.Contains("h"))
                    Hour = int.Parse(item);
            }

            return new TimeSpan(Hour,Minute,Second);
        }

        /// <summary>
        /// Tell the user that the CetusCycle is updated
        /// </summary>
        /// <param name="args"></param>
        public virtual void OnCetusCycleUpdated(CetusCycleUpdatedEventArgs args)
        {
            EventHandler<CetusCycleUpdatedEventArgs> handler = CetusCycleUpdated;
            handler?.Invoke(this,args);
        }


    }
}
