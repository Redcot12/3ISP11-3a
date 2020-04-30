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
using System.IO;


namespace _3ISP11_3a
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWin.xaml
    /// </summary>
    public partial class RegistrationWin : Window
    {

        GameShopEntities contex = new GameShopEntities();

        //string path = @"C:\Users\Степан\Videos\Desktop\Адышкин дист\Project reg Files\EmailRig.txt";
        public RegistrationWin()
        {
            InitializeComponent();

        }

        private void Cancelb_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Enterb_Click(object sender, RoutedEventArgs e)
        {
            if(LoginTXT.Text.Length > 0)
            {
                if (PasswordTXTR.Text.Length >= 6)
                {
                    if(TestPAss.Text.Length > 0)
                    {
                        if(FamTXT.Text.Length > 0)
                        {
                            if(NameTXT.Text.Length > 0)
                            {
                                if(EmailTXT.Text.Length > 0)
                                    {
                                        string[] Dog = EmailTXT.Text.Split('@'); // делим строку на две части

                                    if (Dog.Length == 2) // проверяем если у нас две части
                                    {
                                        string[] Tochka = Dog[1].Split('.'); // делим вторую часть ещё на две части
                                        if (Tochka.Length == 2)
                                        {
                                            if(DateC.Text.Length > 0)
                                            {
                                                var qwerty = contex.user.Where(i => i.login == LoginTXT.Text).ToList();

                                                if (qwerty.Count < 1)
                                                {
                                                    try
                                                    {
                                                        contex.user.Add(new user
                                                        {
                                                            lastName = FamTXT.Text,
                                                            firstName = NameTXT.Text,
                                                            middleName = TreeNameTXT.Text,
                                                            login = LoginTXT.Text,
                                                            password = PasswordTXTR.Text,
                                                            birthdate = DateC.DisplayDate,
                                                            email = EmailTXT.Text,
                                                            
                                                            isDeleted = false
                                                           
                                                            

                                                        });
                                                        
                                                        contex.SaveChanges();

                                                        this.Close();

                                                    }
                                                    
                                                    catch (Exception ex)
                                                    {
                                                        MessageBox.Show(ex.Message.ToString());
                                                    }
                                                }
                                                
                                                MessageBox.Show("Все поля прошли проверку");
                                            }
                                            else
                                            {
                                                MessageBox.Show("Укажите дату вашего рождения");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Почтовый адрес должен выглядеть так __@___.__"); 
                                        }

                                    }
                        else MessageBox.Show("Почтовый адрес должен выглядеть так __@___.__");
                            }
                        else
                         {
                            MessageBox.Show("Поле 'почта' является обязательным для заполнения");
                      }
                                
                            }
                            else
                            {
                                MessageBox.Show("Поле 'Имя' обязательное для заполнения");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Поле 'Фамилия' обязательное для заполнения");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Поле 'Повтор пароля' обязательное для заполнения");
                    }
                }
                else
                {
                     MessageBox.Show("Пароль слишком короткий");
                }
            }
            else
            {
                MessageBox.Show("Поле 'Логин' обязательное для заполнения");
            }

        }

        private void LoginTXT_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
         //  e.Handled = true;
        }

        private void Grid_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;

            }

        }

        private void FamTXT_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = (char.IsDigit(e.Text, 0));
        }
    }
}
