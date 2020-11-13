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
    public partial class WindowMenu : Window
    {
        public WindowMenu(string TypeUser)
        {
            InitializeComponent();

            if (TypeUser == "admin")
            {
                this.Title = "Режим администратора";
                btn_write.Visibility = Visibility.Visible;
                btn_fije.Visibility = Visibility.Visible;
            }
            else
            {
                this.Title = "Меню";
            }
        }

        private void Btn_back_Click(object sender, RoutedEventArgs e)
        {
            Forms.WindowAuth auth = new WindowAuth();
            auth.Show();
            this.Close();
        }

        private void Btn_clients_Click(object sender, RoutedEventArgs e)
        {
            Forms.WindowClients clients = new WindowClients();
            clients.Show();
            this.Close();
        }

        private void Btn_services_Click(object sender, RoutedEventArgs e)
        {
            Forms.WindowServices services = new WindowServices();
            services.Show();
            this.Close();
        }

        private void Btn_showClientServices_Click(object sender, RoutedEventArgs e)
        {
            Forms.WindowClientServices clientservices = new WindowClientServices();
            clientservices.Show();
            this.Close();
        }

        private void Btn_write_Click(object sender, RoutedEventArgs e)
        {
            Forms.WindowWrite write = new WindowWrite();
            write.Show();
            this.Close();
        }

        private void Btn_fije_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
