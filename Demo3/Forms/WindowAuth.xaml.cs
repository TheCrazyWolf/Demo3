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
using System.Windows.Shapes;

namespace Demo3.Forms
{
    /// <summary>
    /// Логика взаимодействия для WindowAuth.xaml
    /// </summary>
    public partial class WindowAuth : Window
    {
        public WindowAuth()
        {
            InitializeComponent();
        }

        private void Btn_enter_Click(object sender, RoutedEventArgs e)
        {
            if (tbox_login.Text == "admin" & tbox_password.Password == "admin")
            {
                Forms.WindowMenu menu = new WindowMenu("admin");
                menu.Show();
                this.Close();
            }
        }

        private void Btn_enter_as_guest_Click(object sender, RoutedEventArgs e)
        {
            Forms.WindowMenu menu = new WindowMenu("user");
            menu.Show();
            this.Close();
        }
    }
}
