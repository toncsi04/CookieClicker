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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int timer1 = 0;
        int points = 0;
        int p50 = 0;
        int p100 = 0;
        int p250 = 0;
        int p500 = 0;
        int p1000 = 0;
        int p1000000 = 0;
        public MainWindow()
        {
            InitializeComponent();


            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(0.99056) };
            timer.Start();
            timer.Tick += (sender, args) =>
            {
                timer1 += 1;
                points += (p50 * 1) + (p250 * 2) + (p250 * p250 - p250 * 2) + (p1000000 * 20000);
                if (points == 0 || points == 1)
                {
                    labelPoints.Content = points.ToString() + " Point";
                }
                else
                { 
                    labelPoints.Content = points.ToString() + " Points";
                }
            };
        }

       

        private void Click_Click(object sender, EventArgs e)
        {
            points += 1 + ((p500 + p500) * 3) + (p100 * 2) + ((p1000 + p1000) * p1000 * p1000 * p1000 - (p1000 * p1000 * p1000)) + (p1000000 * 100000);

            if (points == 0 || points == 1)
            {
                labelPoints.Content = points.ToString() + " Point";
            }
            else
            {
                labelPoints.Content = points.ToString() + " Points";
            }

        }

        private void otven_Click(object sender, RoutedEventArgs e)
        {     

            if (p50 >= 20)
            {
                MessageBox.Show("This upgrade is already maxed!");
                
            }
            else if (points >= 50)
            {
                p50 += 1;
                points -= 50;
                l50.Content = "50p Upgrades: " + p50.ToString();
                if (p50 == 20)
                {
                    l50.Content = "50p Upgrades: " + p50.ToString() + " (max)";
                }
                if (points == 0 || points == 1)
                {
                    labelPoints.Content = points.ToString() + " Point";
                }
                else
                {
                    labelPoints.Content = points.ToString() + " Points";
                }
            }

        }

        private void szaz_Click(object sender, RoutedEventArgs e)
        {
            if (p100 >= 15)
            {
                MessageBox.Show("This upgrade is already maxed!");
            }
            else if (points >= 100)
            {
                p100 += 1;
                points -= 100;
                l100.Content = "100p Upgrades: " + p100.ToString();
                if (p100 == 15)
                {
                    l100.Content = "100p Upgrades: " + p100.ToString() + " (max)";
                }
                if (points == 0 || points == 1)
                {
                    labelPoints.Content = points.ToString() + " Point";
                }
                else
                {
                    labelPoints.Content = points.ToString() + " Points";
                }
            }
        }

        private void ketszazotven_Click(object sender, RoutedEventArgs e)
        {
            if (p250 >= 12)
            {
                MessageBox.Show("This upgrade is already maxed!");
                
            }
            else if (points >= 250)
            {
               p250 += 1;
               points -= 250;
                l250.Content = "250p Upgrades: " + p250.ToString();
                if (p250 == 12)
                {
                    l250.Content = "250p Upgrades: " + p250.ToString() + " (max)";
                }
                if (points == 0 || points == 1)
                {
                    labelPoints.Content = points.ToString() + " Point";
                }
                else
                {
                    labelPoints.Content = points.ToString() + " Points";
                }
            }
        }

        private void otszaz_Click(object sender, RoutedEventArgs e)
        {
            if (p500 >= 10) 
            {
                MessageBox.Show("This upgrade is already maxed!");
            }
            else if (points >= 500)
            {
                p500 += 1;
                points -= 500;
                l500.Content = "500p Upgrades: " + p500.ToString();
                if (p500 == 10)
                {
                    l500.Content = "500p Upgrades: " + p500.ToString() + " (max)";
                }
                if (points == 0 || points == 1)
                {
                    labelPoints.Content = points.ToString() + " Point";
                }
                else
                {
                    labelPoints.Content = points.ToString() + " Points";
                }
            }
        }

        private void ezer_Click(object sender, RoutedEventArgs e)
        {
            if (p1000 >= 8)
            {
                MessageBox.Show("This upgrade is already maxed!");
            }
            else if (points >= 1000)
            {
                p1000 += 1;
                points -= 1000;
                l1000.Content = "1000p Upgrades: " + p1000.ToString();
                if (p1000 == 8)
                {
                    l1000.Content = "1000p Upgrades: " + p1000.ToString() + " (max)";
                }
                if (points == 0 || points == 1)
                {
                    labelPoints.Content = points.ToString() + " Point";
                }
                else
                {
                    labelPoints.Content = points.ToString() + " Points";
                }
            }
        }

        private void millio_Click(object sender, RoutedEventArgs e)
        {
            if (points >= 1000000)
            {
                p1000000 += 1;
                points -= 1000000;
                l1000000.Content = "1000000p Upgrades: " + p1000000.ToString();
                if (p1000000 == 1)
                {
                    l1000000.Content = "1000000p Upgrades: " + p1000000.ToString() + " (max)";
                }
                if (points == 0 || points == 1)
                {
                    labelPoints.Content = points.ToString() + " Point";
                }
                else
                {
                    labelPoints.Content = points.ToString() + " Points";
                }
                MessageBox.Show($"Congratulations! You passed this minigame!");
            }
            else if (points < 1000000)
            {
                MessageBox.Show("Buy this upgrade to complete this minigame!");
            }
        }
    }
}
