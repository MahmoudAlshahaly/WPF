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

namespace day2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        float fnum;
        float snum;
        char opration;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            txt_res.Text += btn.Content.ToString();
            snum = float.Parse(txt_res.Text);
        }

        private void div_btn_Click(object sender, RoutedEventArgs e)
        {
            fnum = float.Parse(txt_res.Text);
            opration = '/';
            txt_res.Clear();
        }

        private void mul_btn_Click(object sender, RoutedEventArgs e)
        {
            fnum = float.Parse(txt_res.Text);
            opration = 'x';
            txt_res.Clear();
        }

        private void sum_btn_Click(object sender, RoutedEventArgs e)
        {
            fnum = float.Parse(txt_res.Text);
            opration = '+';
            txt_res.Clear();
        }

        private void equal_btn_Click(object sender, RoutedEventArgs e)
        {
            float result = 0;
            switch (opration)
            {
                case '+':
                    result = fnum + snum;
                    break;
                case '-':
                    result = fnum - snum;
                    break;
                case 'x':
                    result = fnum * snum;
                    break;
                default:
                    result = fnum / snum;
                    break;

            }
            if (result == 0)
            {
                txt_res.Clear();
            }
            else
            {
                txt_res.Text = result.ToString();
            }
        }

        private void sub_btn_Click(object sender, RoutedEventArgs e)
        {
            fnum = float.Parse(txt_res.Text);
            opration = '-';
            txt_res.Clear();
        }
    }
    
}
