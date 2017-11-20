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

    public class MainStatUpdatedEventArgs : EventArgs
    {
        public MainStat NewStat;
    }

    /// <summary>
    /// Main class for updating a MainStat class
    /// </summary>
    public class MainStatUpdator
    {
        /// <summary>
        /// Counter for seeing if should get a new mainstat
        /// </summary>
        private int CounterForNewWarframStat = 0;

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

        public event EventHandler<MainStatUpdatedEventArgs> MainStatusUpdated;

        /// <summary>
        /// Initializes MainStatUpdator. And auto gets a MainStat using the statGetterType param
        /// </summary>
        /// <param name="statGetterType">What type of MainStatGetter to use</param>
        public MainStatUpdator(MainStatGetterType statGetterType)
        {
            getterType = statGetterType;
            GetNewMainStat();
            Timer = new DispatcherTimer();
            Timer.Tick += new EventHandler(UpdateStat);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
        }

        /// <summary>
        /// Initializes MainStatUpdator with an already made MainStat
        /// </summary>
        /// <param name="inputStat">Already made input MainStat param</param>
        public MainStatUpdator(MainStat inputStat)
        {
            stat = inputStat;
            Timer = new DispatcherTimer();
            Timer.Tick += new EventHandler(UpdateStat);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
        }

        /// <summary>
        /// Initializes MainStatUpdator
        /// </summary>
        /// <param name="inputStat">Already made input MainStat param</param>
        /// <param name="statGetterType">What type of getter the class will use to update the input for future use</param>
        public MainStatUpdator(MainStat inputStat,MainStatGetterType statGetterType)
        {
            stat = inputStat;
            Timer = new DispatcherTimer();
            Timer.Tick += new EventHandler(UpdateStat);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();

            getterType = statGetterType;
        }

        /// <summary>
        /// Destructor. stops timer and sets the events to null
        /// </summary>
        ~MainStatUpdator()
        {
            Timer.Stop();
            CetusCycleUpdated = null;
        }

        /// <summary>
        /// Updates all the neccesary values in the stat property
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateStat(object sender, EventArgs e)
        {
            if(CounterForNewWarframStat < 1000)
            {
                stat.CetusCycle = UpdateCetusCycle(stat.CetusCycle, new TimeSpan(0, 0, 1));
                OnMainStatUpdated(new MainStatUpdatedEventArgs() { NewStat = stat });

                CounterForNewWarframStat++;
            }
            else
            {
                CounterForNewWarframStat = 0;
                GetNewMainStat();
            }

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
            if (TimeLeft > new TimeSpan(0, 0, 1))
            {
                TimeLeft -= TimeAmountChanged;
                cycle.TimeLeft = String.Format("{0}h {1}m {2}s", TimeLeft.Hours, TimeLeft.Minutes, TimeLeft.Seconds);
                OnCetusCycleUpdated(new CetusCycleUpdatedEventArgs() { NewCycle = cycle });
                return cycle;
            }
            else
            {
                CounterForNewWarframStat = 0;
                GetNewMainStat();
                return stat.CetusCycle;
            }
        }

        /// <summary>
        /// Gets a new MainStat from a MainStatGetter
        /// </summary>
        private void GetNewMainStat()
        {
            MainStatGetterFactory factory = new MainStatGetterFactory();
            AbstractMainStatGetter statGetter = factory.GetMainStatGetter(getterType);
            stat = statGetter.GetMainStat();
        }

        /// <summary>
        /// Converts the time left string to a timespan
        /// </summary>
        /// <param name="Time">The input time string formatted like this "5h 2m 20s"</param>
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

        protected virtual void OnMainStatUpdated(MainStatUpdatedEventArgs args)
        {
            EventHandler<MainStatUpdatedEventArgs> handler = MainStatusUpdated;
            handler?.Invoke(this, args);
        }




    }
}
