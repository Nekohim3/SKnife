using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace SKnife
{
    /// <summary>
    /// Логика взаимодействия для Stats.xaml
    /// </summary>
    public partial class Stats : MetroWindow
    {
        public Stats(List<SSKnife> stats)
        {
            InitializeComponent();
            foreach (SSKnife x in stats)
                DG.Items.Insert(0, x);
        }

        private void DG_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (DG.SelectedIndex != -1)
            {
                Process.Start((DG.Items[DG.SelectedIndex] as SSKnife).sender);
            }
        }
    }
}
