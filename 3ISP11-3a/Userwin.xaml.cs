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

namespace _3ISP11_3a
{
    /// <summary>
    /// Логика взаимодействия для Userwin.xaml
    /// </summary>
    public partial class Userwin : Window
    {
        //  UserLoginClass.LoginUser;

        Entities1 context = new Entities1();
        public Userwin()
        {
            InitializeComponent();
            //LnameLB.Content = context.user.Where(i => i.login == UserLoginClass.LoginUser).Select(i => i.lastName).FirstOrDefault();
            //FnameLB.Content = context.user.Where(i => i.login == UserLoginClass.LoginUser).Select(i => i.firstName).FirstOrDefault();
            //MnameLB.Content = context.user.Where(i => i.login == UserLoginClass.LoginUser).Select(i => i.middleName).FirstOrDefault();
            ////ID.Content = context.user.Where(i => i.login == UserLoginClass.LoginUser).Select(i => i.lastName).FirstOrDefault();

            //GridGame.ItemsSource = context.game.ToList();
            //ListFriend.ItemsSource = context.FriendShip.ToList();
        }

        private void ParCont_Click(object sender, RoutedEventArgs e)
        {
            ParentalControl pac = new ParentalControl();
            this.Hide();
            pac.Show();
            this.Show();
        }

        private void Redprof_Click(object sender, RoutedEventArgs e)
        {
            EditUser ed = new EditUser();
            this.Hide();
            ed.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LnameLB.Content = context.user.Where(i => i.login == UserLoginClass.LoginUser).Select(i => i.lastName).FirstOrDefault();
            FnameLB.Content = context.user.Where(i => i.login == UserLoginClass.LoginUser).Select(i => i.firstName).FirstOrDefault();
            MnameLB.Content = context.user.Where(i => i.login == UserLoginClass.LoginUser).Select(i => i.middleName).FirstOrDefault();
            //ID.Content = context.user.Where(i => i.login == UserLoginClass.LoginUser).Select(i => i.lastName).FirstOrDefault();

            GridGame.ItemsSource = context.game.ToList();
            //ListFriend.ItemsSource = context.FriendShip.ToList();
        }
    }
}
