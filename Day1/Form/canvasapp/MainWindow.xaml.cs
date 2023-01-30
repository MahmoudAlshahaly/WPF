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

namespace canvasapp
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

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            string DATA = $"name: {txtFirstName.Text}{txtLastName.Text} \n gender : {txtGender.Text} \n address : {txtAddress.Text} \n phone : {txtPhone.Text} \n mobile : {txtMobile.Text} \n email : {txtEmail.Text} \n jop : {txtJop.Text} \n";
            if(MessageBox.Show(DATA,"UserInfo",MessageBoxButton.OKCancel,MessageBoxImage.Information)==MessageBoxResult.OK)
            {
                MessageBox.Show("Data Saved");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtGender.Clear();
            txtJop.Clear();
            txtAddress.Clear();
            txtMobile.Clear();
        }
    }
}
