using System;
using System.Collections.Generic;
using System.IO;
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

namespace _3ISP11_3a
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Entities1 contex = new Entities1();

        Random rnd = new Random();
        string path = @"F:\Записи уроков\Адышкин дист\Users Library.txt";
        int pope = 0;
        //string log = "qwe";
        //string pas = "123";

       

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CaptchaLB.Content = rnd.Next(100000, 999999);
            if (File.Exists(path))
            {

                using (StreamReader sr = new StreamReader(path))
                {
                    string str = sr.ReadToEnd();
                    string[] mass = str.Split();
                    LoginTXT.Text = mass[0];
                    PasswordTXT.Password = mass[1];
                }
            }
        }

        public void CaptchaTXT_Click(object sender, RoutedEventArgs e)
        {
            CaptchaLB.Content = rnd.Next(100000, 999999);
        }

        private void Enterb_Click(object sender, RoutedEventArgs e)
        {
            var qwery = contex.user.Where(i => i.login == LoginTXT.Text && i.password == PasswordTXT.Password).ToList();
           
            if (pope < 5)
            {
                if (qwery.Count > 0)
                {
                    if (pope != 5)
                    {

                        // if (LoginTXT.Text == log && PasswordTXT.Password == pas)
                        //{
                        if (CaptchaLB.Content.ToString() == Captchatxt.Text)
                        {
                            if (RememberME.IsChecked == true)
                            {
                                using (StreamWriter sw = new StreamWriter(path))
                                {
                                    sw.Write($"{LoginTXT.Text} {PasswordTXT.Password}");



                                }

                            }
                            UserLoginClass.LoginUser = LoginTXT.Text;

                            this.Hide();
                            Userwin U = new Userwin();
                            U.Show();

                            MessageBox.Show("Ты смог пройти авторизацию, молодец");

                        }
                        else
                        {
                            MessageBox.Show("Данные не совподают капча", "Ошибка", MessageBoxButton.OKCancel, MessageBoxImage.Error);
                        }
                        // }
                        // else
                        ////{
                        //    CaptchaLB.Content = rnd.Next(100000, 999999);
                        //    MessageBox.Show("Ошибка в поле Логин или Пароль паски");
                        //    pope++;
                        //}
                    }
                    else
                    {
                        CaptchaLB.Content = rnd.Next(100000, 999999);
                        MessageBox.Show("Превышено кол-во попыток ввхода форма будет заблокирована ");
                        //Enterb.IsEnabled = false;
                        this.IsEnabled = false;


                    }
                }
                else
                {
                    CaptchaLB.Content = rnd.Next(100000, 999999);
                    pope++;
                    MessageBox.Show("Пользователь с такими данными не зарегестрирован ");
                }
            }
            else
            {
                CaptchaLB.Content = rnd.Next(100000, 999999);
                MessageBox.Show("Превышено кол-во попыток ввхода вход будет заблокирован ");
                //Enterb.IsEnabled = false;
                Enterb.IsEnabled = false;
            }
           
        }
       
        
        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            RegistrationWin RegistrationWin = new RegistrationWin();
            this.Hide();
            RegistrationWin.ShowDialog();
            this.Show();

        }
    }
}
