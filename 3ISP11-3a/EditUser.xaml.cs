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
using Microsoft.Win32;

namespace _3ISP11_3a
{
    /// <summary>
    /// Логика взаимодействия для EditUser.xaml
    /// </summary>
    public partial class EditUser : Window
    {
        GameShopEntities contex = new GameShopEntities();
        public EditUser()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var dataUser = contex.user.Where(i => i.login == UserLoginClass.LoginUser).ToList();
            LoginTXT.Text = dataUser.Select(i => i.login).FirstOrDefault();
            PasswordTXTR.Text = dataUser.Select(i => i.password).FirstOrDefault();
            FamTXT.Text = dataUser.Select(i => i.lastName).FirstOrDefault();
            NameTXT.Text = dataUser.Select(i => i.firstName).FirstOrDefault();
            TreeNameTXT.Text = dataUser.Select(i => i.middleName).FirstOrDefault();
            EmailTXT.Text = dataUser.Select(i => i.email).FirstOrDefault();
            DateC.SelectedDate = dataUser.Select(i => i.birthdate).FirstOrDefault();

        }

        private void Cancelb_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();


        }

        private void Enterb_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Сохранить изменения?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
            {


                var dataUser = contex.user.Where(i => i.login == UserLoginClass.LoginUser).FirstOrDefault();
                dataUser.login = LoginTXT.Text;
                dataUser.password = PasswordTXTR.Text;
                dataUser.lastName = FamTXT.Text;
                dataUser.firstName = NameTXT.Text;
                dataUser.middleName = TreeNameTXT.Text;
                dataUser.email = EmailTXT.Text;
                dataUser.birthdate = DateC.DisplayDate;
                contex.SaveChanges();

                Userwin userwin = new Userwin();
                this.Close();
                userwin.ShowDialog();
            }
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Удалить Пользователя?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {


                contex.user.Remove(contex.user.Where(i => i.login == UserLoginClass.LoginUser).FirstOrDefault());
                contex.SaveChanges();

               
            }
        }

        private void opfil_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            if (opf.ShowDialog() == true)
            {
            var FilePath = opf.FileName;
                ImUs.Source = new BitmapImage(new Uri(FilePath));
            }
        }
    }
}
