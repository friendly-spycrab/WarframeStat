using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WarframeStat.MainStatGetter;
using WarframeStat.Statistics;

namespace WarframeStat
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainStatUpdator Updator;


        public MainWindow()
        {
            InitializeComponent();

            // Start the event for cetuscycle
            MainStatGetterFactory factory = new MainStatGetterFactory();
            AbstractMainStatGetter statGetter = factory.GetMainStatGetter(MainStatGetterType.FromWarframeStat);
            Updator = new MainStatUpdator(statGetter.GetMainStat());
            Updator.CetusCycleUpdated += new EventHandler<CetusCycleUpdatedEventArgs>(CetusCycleUpdated);
            Updator.MainStatusUpdated += new EventHandler<MainStatUpdatedEventArgs>(MainStatUpdated);
        }

        /// <summary>
        /// Is called when main stat is updated 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainStatUpdated(object sender, MainStatUpdatedEventArgs e)
        {
            // Set sortie information
            misType1.Text = e.NewStat.Sortie.Variants[0].MissionType;
            misType2.Text = e.NewStat.Sortie.Variants[1].MissionType;
            misType3.Text = e.NewStat.Sortie.Variants[2].MissionType;
            misMod1.Text = e.NewStat.Sortie.Variants[0].Modifier;
            misMod2.Text = e.NewStat.Sortie.Variants[1].Modifier;
            misMod3.Text = e.NewStat.Sortie.Variants[2].Modifier;

            // Display alert
            AlertGrid.Children.Clear();
            int xIndex = 0;
            int yIndex = 0;
            foreach (Alert item in e.NewStat.Alerts)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var Rewards in item.RewardTypes)
                {
                    sb.AppendLine(Rewards);
                }
                TextBlock Eta = new TextBlock();
                Eta.Text = item.Eta;
                Eta.Margin = new Thickness() { Left = xIndex * 100 + 50,Top = 10+ (yIndex * 80)  };                
                AlertGrid.Children.Add(Eta);

                TextBlock RewardsType = new TextBlock();
                if(sb.ToString() == "")
                {
                    RewardsType.Text = "Credits";
                }
                else
                {
                    RewardsType.Text = sb.ToString();
                }
                RewardsType.Margin = new Thickness() { Left = xIndex * 100 + 50, Top = 30 + (yIndex * 80) };
                AlertGrid.Children.Add(RewardsType);


                if(xIndex < 4)
                    xIndex++;
                else
                {
                    xIndex = 0;
                    yIndex++;
                }
            }

            

        }

        private void CetusCycleUpdated(object sender, CetusCycleUpdatedEventArgs e)
        {
            
            DayNight.Content = e.NewCycle.IsDay ? "Day" : "Night";
            TimeLeft.Content = e.NewCycle.TimeLeft;
        }

        
    }
}
