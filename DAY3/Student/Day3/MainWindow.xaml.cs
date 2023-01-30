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

namespace Day3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<students> students { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            students = new List<students>()
            {
                new students() {name="ahmed" , img="img.jpg" , id=1 , age=25 , grade=50 },
                new students() {name="eslam" , img="img2.jpg" , id=2 , age=20 , grade=55 },
                new students() {name="eman" , img="img3.jpg" , id=3 , age=24 , grade=40 },
                new students() {name="mahmoud" , img="img.jpg" , id=4 , age=25 , grade=56},

            };
            lst.ItemsSource = students;
        }
    }
}
