﻿using System;
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
            MessageBox.Show(e.NewStat.Sortie.Variants.ToString());
        }

        private void CetusCycleUpdated(object sender, CetusCycleUpdatedEventArgs e)
        {
            
            DayNight.Content = e.NewCycle.IsDay ? "Day" : "Night";
            TimeLeft.Content = e.NewCycle.TimeLeft;
        }

        
    }
}
