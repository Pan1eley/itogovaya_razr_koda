﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Windows.Threading;


namespace Itogovaya_rabota_provider
{
   

    public partial class MainWindow : Window
    {
        DispatcherTimer timercode = new DispatcherTimer(); //таймер для введения кода

        public static string number; //поля для записи корректных данных
        public static string pass;

        public static string anum; //сгенерированный код

        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(int a)
        {
            InitializeComponent();

            tbPassword.Text = pass;
            tbNumber.Text = number;

            btnEnter.IsEnabled = true;

            CodeGenerator();

            //таймер на введение кода
            timercode.Interval = new TimeSpan(0, 0, 10);
            timercode.Start();
            timercode.Tick += new EventHandler(again);
        }

        public void again(object sender, EventArgs e) //выводит сообщение и разблокирует кнопку обновления пароля
        {
            if (tbCode.Text == anum)
            {

            }

            else
            {
                MessageBox.Show("Сгенерируйте новый код", "Время истекло", MessageBoxButton.OK);

                tbCode.Text = "";

                btnEnter.IsEnabled = false;
                btnReset.IsEnabled = true;
            }
            timercode.Stop();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e) //событие на кнопку входа
        {
            User autoUser = BaseModel.GetContext().Users.FirstOrDefault(x => x.Login == tbCode.Text && x.Password == tbPassword.Text);
        


            if (tbCode.Text == anum) //сравнивам со сгенерированным кодом 
            {
                switch (autoUser.IdRole) //проверяем роль пользователя
                {
                    case 1:
                        MessageBox.Show("Ваша роль - руководитель отдела по работе с клиентами");
                        break;

                    case 2:
                        MessageBox.Show("Ваша роль - менеджер по работе с клиентами");
                        break;

                    case 3:
                        MessageBox.Show("Ваша роль - руководитель отдела технической поддержки");
                        break;

                    case 4:
                        MessageBox.Show("Ваша роль - специалист технической поддержки");
                        break;

                    case 5:
                        MessageBox.Show("Ваша роль - бухгалтер");
                        break;

                    case 6:
                        MessageBox.Show("Ваша роль - директор по развитию");
                        break;

                    case 7:
                        MessageBox.Show("Ваша роль - сотрудник технического депортамента");
                        break;
                }
            }
            else
            {

                if (tbCode.Text == " ") //пустое значение
                {
                    MessageBox.Show("Вы не ввели код, сгенерируйте новый");
                }

                if (tbCode.Text != anum || tbCode.Text != " ") //неверный код, подставить сгенерированный код
                {
                    MessageBox.Show("Ошибка ввода");
                }

                tbCode.IsEnabled = false;
                btnEnter.IsEnabled = false;
                btnReset.IsEnabled = true;
            }

            timercode.Stop();
        }

        public void CodeGenerator() //генерация кода
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower();
            var char2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var nums = "1234567890";
            var symbs = "!@#$%^&*";

            Random random = new Random();
            var stringChars = new char[8];

            for (int i = 0; i <= 1; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            for (int i = 2; i <= 3; i++)
            {
                stringChars[i] = char2[random.Next(char2.Length)];
            }

            for (int i = 4; i <= 5; i++)
            {
                stringChars[i] = nums[random.Next(nums.Length)];
            }

            for (int i = 6; i <= 7; i++)
            {
                stringChars[i] = symbs[random.Next(symbs.Length)];
            }

            anum = new String(stringChars);
            MessageBox.Show(anum, "Запомните одноразовый код", MessageBoxButton.OK); //вывод сообщения со сгенерированным значением 
            tbCode.Focus(); //курсор в поле для кода
        }

        private void btnCancle_Click(object sender, RoutedEventArgs e) //очистка значений
        {
            tbCode.Text = "";
            tbNumber.Text = "";
            tbPassword.Text = "";
        }

        private void btnReset_Click(object sender, RoutedEventArgs e) //сгенерировать новый пароль
        {
            tbCode.Text = "";

            tbCode.IsEnabled = true;

            btnEnter.IsEnabled = true;
            btnReset.IsEnabled = false;

            CodeGenerator();
        }

        private void tbNumber_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.Key == Key.Enter)
            {
                if (tbNumber.Text == "" || tbNumber.Text == " ") //допущена ошибка
                {
                    MessageBox.Show("Ошибка ввода");
                    return;
                }

                User autoUser = BaseModel.GetContext().Users.FirstOrDefault(x => x.Login == tbNumber.Text);

                if (autoUser == null)
                {
                    MessageBox.Show("Пользователь с таким номером не найден");
                }
                else
                {
                    tbPassword.IsEnabled = true;
                    tbPassword.Focus();
                }
            }
        }

        private void tbPasswoed_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Enter) //тут проверяем правильность пароля
            {
                if (tbPassword.Text == "" || tbPassword.Text == " ")
                {
                    MessageBox.Show("Ошибка ввода");
                    return;
                }

                User autoUser = BaseModel.GetContext().Users.FirstOrDefault(x => x.Password == tbPassword.Text);

                if (autoUser == null) //записываем данные при успешном вводе
                {
                    MessageBox.Show("Неверный пароль", "Повторите ввод", MessageBoxButton.OK);
                }
                else
                {
                    number = tbNumber.Text;
                    pass = tbPassword.Text;

                    MessageBox.Show("Верный пароль");
                    FrameClass.MainFrame.Navigate(new MainWindow(1));
                }
            }
        }
    }



}

    

