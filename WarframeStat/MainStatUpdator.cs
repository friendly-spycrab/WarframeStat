using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using WarframeStat.Statistics;
using System.Windows.Threading;
using WarframeStat.MainStatGetter;

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
        /// <summary>
        /// A private mainstat property
        /// </summary>
        public MainStat stat { get; private set; }

        /// <summary>
        /// Dispatcher timer for updating the mainstat
        /// </summary>
        private DispatcherTimer Timer;

        /// <summary>
        /// gettertype to get for updating type
        /// </summary>
        public MainStatGetterType getterType { get; set; } = MainStatGetterType.FromWarframeStat;

        public event EventHandler<CetusCycleUpdatedEventArgs> CetusCycleUpdated;

        public MainStatUpdator(MainStatGetterType statGetterType)
        {
            getterType = statGetterType;
            GetNewMainStat();
            Timer = new DispatcherTimer();
            Timer.Tick += new EventHandler(UpdateStat);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
        }

        public MainStatUpdator(MainStat inputStat)
        {
            stat = inputStat;
            Timer = new DispatcherTimer();
            Timer.Tick += new EventHandler(UpdateStat);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
        }

        public MainStatUpdator(MainStat inputStat,MainStatGetterType statGetterType)
        {
            stat = inputStat;
            Timer = new DispatcherTimer();
            Timer.Tick += new EventHandler(UpdateStat);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();

            getterType = statGetterType;
        }

        ~MainStatUpdator()
        {
            Timer.Stop();
            CetusCycleUpdated = null;
        }

        private void UpdateStat(object sender, EventArgs e)
        {
            stat.CetusCycle = UpdateCetusCycle(stat.CetusCycle,new TimeSpan(0,0,1));
        }

        /// <summary>
        /// Returns an updated cetuscycle object
        /// </summary>
        /// <param name="cycle"></param>
        /// <param name="TimeAmountChanged">Amount of time that has gone by since the last update</param>
        /// <returns></returns>
        private CetusCycle UpdateCetusCycle(CetusCycle cycle,TimeSpan TimeAmountChanged)
        {
            TimeSpan TimeLeft = ToTimeSpan(cycle.TimeLeft);
            TimeLeft -= TimeAmountChanged;
            cycle.TimeLeft = String.Format("{0}h {1}m {2}s", TimeLeft.Hours, TimeLeft.Minutes, TimeLeft.Seconds);
            OnCetusCycleUpdated(new CetusCycleUpdatedEventArgs() { NewCycle = cycle });
            return cycle;
        }

        private void GetNewMainStat()
        {
            MainStatGetterFactory factory = new MainStatGetterFactory();
            AbstractMainStatGetter statGetter = factory.GetMainStatGetter(getterType);
            stat = statGetter.GetMainStat();
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
                    Second = int.Parse(item.Remove(item.Length - 1));
                else if (item.Contains("m"))
                    Minute = int.Parse(item.Remove(item.Length - 1));
                else if(item.Contains("h"))
                    Hour = int.Parse(item.Remove(item.Length - 1));
            }

            return new TimeSpan(Hour,Minute,Second);
        }

        /// <summary>
        /// Tell the user that the CetusCycle is updated
        /// </summary>
        /// <param name="args"></param>
        protected virtual void OnCetusCycleUpdated(CetusCycleUpdatedEventArgs args)
        {
            EventHandler<CetusCycleUpdatedEventArgs> handler = CetusCycleUpdated;
            handler?.Invoke(this,args);
        }


    }
}
