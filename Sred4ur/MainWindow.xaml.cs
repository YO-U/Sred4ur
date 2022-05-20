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

namespace Sred4ur
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TimeSpan Vre;
        Vrem vr = new Vrem();
        
        
        public MainWindow()
        {
            InitializeComponent();
        }
        public void CHAS_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CHAS.Text != "")
            {
                if (CHAS.Text != "")
                {
                    int ch;
                    ch = Convert.ToInt32(CHAS.Text);
                    if (ch >= 24)
                    {
                        Console.WriteLine("Введите число меньше 24");
                    }
                    else
                    {
                        vr.hours = ch;
                    }
                }
            }
        }

        public void MIN_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (MIN.Text != "")
            {
                int m;
                m = Convert.ToInt32(MIN.Text);
                if (m >= 60)
                {
                    Console.WriteLine("Введите число меньше 60");
                }
                else
                {
                    vr.minutes = m;
                }
            }
        }

        public void SEC_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SEC.Text != "")
            {
                int s;
                s = Convert.ToInt32(SEC.Text);
                if (s >= 60)
                {
                    Console.WriteLine("Введите число меньше 60");
                }
                else
                {
                     vr.seconds = s;
                }
            }
        }
        private void KnopPer_Click(object sender, RoutedEventArgs e)
        {
            Vre = new TimeSpan(vr.hours,vr.minutes,vr.seconds);
            Per.Text = Vre.ToString("T");
            if (Vre.TotalSeconds > DateTime.Now.Second)
            {
                var result = Vre.TotalSeconds - DateTime.Now.Second;

                var minutes = (int)(result / 60);
                var seconds = (int)(result % 60);
                var hours = (int)(minutes / 60);
                if (hours > 24)
                {
                    hours -= 24;
                }
                TimeSpan time = new TimeSpan(hours, minutes, seconds);
                OstPer.Text = time.ToString("T");  
            }
            else
            {
                var result = 86400 - DateTime.Now.Second ;
                result +=(int) Vre.TotalSeconds;
                var minutes = (int)(result / 60);
                var seconds = (int)(result % 60);
                var hours = (int)(minutes / 60);
                if (hours > 24)
                {
                    hours -= 24;
                }
                TimeSpan time = new TimeSpan(hours, minutes, seconds);
                OstPer.Text = time.ToString("T");
            }
                     
        }

        private void KnopVtor_Click(object sender, RoutedEventArgs e)
        {
            Vre = new TimeSpan(vr.hours, vr.minutes, vr.seconds);
            Vtor.Text = Vre.ToString("T");
            if (Vre.TotalSeconds > DateTime.Now.Second)
            {
                var result = Vre.TotalSeconds - DateTime.Now.Second;

                var minutes = (int)(result / 60);
                var seconds = (int)(result % 60);
                var hours = (int)(minutes / 60);
                if (hours > 24)
                {
                    hours -= 24;
                }
                TimeSpan time = new TimeSpan(hours, minutes, seconds);
                OstVtor.Text = time.ToString("T");
            }
            else
            {
                var result = 86400 - DateTime.Now.Second;
                result += (int)Vre.TotalSeconds;
                var minutes = (int)(result / 60);
                var seconds = (int)(result % 60);
                var hours = (int)(minutes / 60);
                if (hours > 24)
                {
                    hours -= 24;
                }
                TimeSpan time = new TimeSpan(hours, minutes, seconds);
                OstVtor.Text = time.ToString("T");
            }
        }
    }
}
