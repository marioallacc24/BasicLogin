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

namespace BasicLogin
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

        private void OtkaziBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        Login login = new Login("admin", "1234");
        private void UlogujBtn_Click(object sender, RoutedEventArgs e)
        {
            string user = korisnickoImeBox.Text;
            string pass = passBox.Password;

            if (login.IsLoggedIn(user, pass))
            {
                MessageBox.Show("Uspesno ste se ulogovali");
            }
            else
            {
                //show default login error message 
                MessageBox.Show("Logovanje nije uspelo");
            }
        }
    }
}
