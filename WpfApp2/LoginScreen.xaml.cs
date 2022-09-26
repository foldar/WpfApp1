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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for LoginSCreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        private LoginBLL _LoginBLL  = new LoginBLL();
        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            _LoginBLL.UserName = this.txtUserName.Text;
            _LoginBLL.password = this.txtPassword.Password;
            _LoginBLL.TestNumber = null;
            this.txtUserName.Text = _LoginBLL.pwdHashed;
        }
    }
}
