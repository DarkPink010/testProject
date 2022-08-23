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

namespace WpfAppGUIProject
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void money_1_TextChanged(object sender, TextChangedEventArgs e)
        {
            int.Parse(money_1.Text);
        }

        private void money_2_TextChanged(object sender, TextChangedEventArgs e)
        {
            int.Parse(money_2.Text);
        }

        private void money_3_TextChanged(object sender, TextChangedEventArgs e)
        {
            int.Parse(money_3.Text);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(money_1.Text) - int.Parse(money_2.Text);
            int b = int.Parse(money_3.Text) / a;
            money_4.Text = b.ToString();
        }

    }
}
