using Assessment.Library;
using Assessment.Models;
using Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.Foundation;
using Windows.UI.ApplicationSettings;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using MySql.Data.MySqlClient;


namespace Assessment.ViewModels
{
    public class LoginViewModel : UserModel
    {
        private ICommand _command;
        private TextBox _textBoxEmail;
        private PasswordBox _textBoxPass;
        private String date = DateTime.Now.ToString("dd/MM/yyyy");
        private Frame rootFrame = Window.Current.Content as Frame;
        private Connections _conn;
        public LoginViewModel(object[] fields) 
        {
            _textBoxEmail = (TextBox)fields[0];
            _textBoxPass = (PasswordBox)fields[1];
            _conn = new Connections();
        }

        public ICommand LoginCommand 
        {
            get 
            {
                return _command  ?? (_command = new CommandHandler(async () =>
                {
                    await loginAsync();
                })); 
            }
        }

        private async Task loginAsync()
        {
            if ( Email == null || Email.Equals(""))
            {
                EmailMessage = "Input your email";
                _textBoxEmail.Focus(FocusState.Programmatic);
            }
            else
            {
                if(TextBoxEvent.IsValidEmail(Email)) 
                {
                    if (Password == null || Password.Equals(""))
                    {
                        PasswordMessage = "Introduce Password";
                        _textBoxPass.Focus(FocusState.Programmatic);
                    }
                    else
                    {
                        var user = _conn.Users.Where(u => u.Email.Equals(Email) && u.Password.Equals(Password)).ToList();
                        var d = user.Count;
                        
                    }
                }
                else
                {
                    EmailMessage = "Invalid Email";
                    _textBoxEmail?.Focus(FocusState.Programmatic);
                }
            }
            
            
        }
    }
}
