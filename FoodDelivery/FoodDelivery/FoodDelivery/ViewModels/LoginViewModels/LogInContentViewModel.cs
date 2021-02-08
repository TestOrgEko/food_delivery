using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Input;
using FoodDelivery.ViewModels;
using Xamarin.Forms;

namespace FoodDelivery.Views
{
    public class LogInContentViewModel : BaseViewModel
    {
        private string login;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }


        private string password;

        public string Passowrd
        {
            get { return password; }
            set { password = value; }
        }


        private string name;
        public string Name
        {
            get => name;
            set => Set(ref name, value);
        }

        private string surname;
        public string Surname
        {
            get => surname;
            set => Set(ref surname, value);
        }

        private string email;
        public string Email
        {
            get => email;
            set => Set(ref email, value);
        }

        private string phoneNumber;
        public string PhoneNumber
        {
            get => phoneNumber;
            set => Set(ref phoneNumber, value);
        }

        public LogInContentViewModel(INavigation navigation) : base(navigation)
        {
            this.login = String.Empty;
            this.email = String.Empty;
            this.email = String.Empty;
            this.name = String.Empty;
            this.surname = String.Empty;
            this.phoneNumber = String.Empty;
        }
    }
}
