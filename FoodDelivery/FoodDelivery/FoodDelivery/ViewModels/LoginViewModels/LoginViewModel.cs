using System;
using System.Collections.Generic;
using System.Text;
using FoodDelivery.Views;
using Xamarin.Forms;

namespace FoodDelivery.ViewModels.LoginViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel(INavigation navigation) : base(navigation)
        {
            this.LogInContentViewModel = new LogInContentViewModel(navigation);
            this.SignInContentViewModel = new SignInContentViewModel(navigation);
        }
        public LogInContentViewModel LogInContentViewModel { get; set; }
        public SignInContentViewModel SignInContentViewModel { get; set; }
    }
}
