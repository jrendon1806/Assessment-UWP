﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Email;

namespace Assessment.Models
{
    public class UserModel : PropertyChangedNotification
    {
        public string Email
        {
            get { return GetValue(() => Email); }
            set
            {
                SetValue(() => Email, value);
                EmailMessage = "";
                Message = "";
            }
        }

        public string Password
        {
            get { return GetValue(() => Password); }
            set 
            { 
                SetValue(() => Password, value);
                PasswordMessage = "";
                Message = "";
            }
        }

        public string Message
        {
            get { return GetValue(() => Message); }
            set { SetValue(() => Message, value);}
        }

        public string PasswordMessage
        {
            get => GetValue(() => PasswordMessage);
            set { SetValue(() => PasswordMessage, value);}
        }

        public string EmailMessage
        {
            get { return GetValue(() => EmailMessage); }
            set
            {
                SetValue(() => EmailMessage, value);
            }
        }
    }
}
