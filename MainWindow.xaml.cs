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

namespace caculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "1";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "9";
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "0";
        }

        private void Button_Click_plus(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "+";
        }

        private void Button_Click_kurang(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "-";
        }
        private void Button_Click_kali(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "*";
        }
        private void Button_Click_bagi(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "/";
        }
        private void Button_Click_delete(object sender, RoutedEventArgs e)
        {
            screen.Text = "";
        }

        private void Button_Click_hasil(object sender, RoutedEventArgs e)
        {
            //screen.Text = screen.Text + "=";
            Type scriptType = Type.GetTypeFromCLSID(Guid.Parse("0E59F1D5-1FBE-11D0-8FF2-00A0D10038BC"));
            dynamic obj = Activator.CreateInstance(scriptType, false);
            obj.Language = "javascript";
            string str = null;

            try
            {
                var res = obj.Eval(screen.Text);
                str = Convert.ToString(res);
                screen.Text = screen.Text + "=" + str;
            }
            catch (SystemException)
            {

                screen.Text = "Salah Input";
            }
        }
    }
}
