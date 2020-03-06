using System;
using System.IO;
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

namespace WPF_Playground
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

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = "Button 2 Clicked";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = "Button 1 Clicked";
        }

        private void btnHello_Click(object sender, RoutedEventArgs e)
        {
            txtBox.Text = "Hellot There";
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string userName = txtUsername.Text;
            string passWord= txtPassword.Text;

            MessageBox.Show("Your Username is " + userName + " and your Password is " + passWord, "Notify");

            txtUser.Text = userName;
            txtPass.Text = passWord;

                File.AppendAllText(@"C:\WPF\" + userName + ".txt", "UserName: " + userName + Environment.NewLine);
       
                File.AppendAllText(@"C:\WPF\" + userName + ".txt", "PassWord: " + passWord + Environment.NewLine);


                
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {

        }

 
    }
}
