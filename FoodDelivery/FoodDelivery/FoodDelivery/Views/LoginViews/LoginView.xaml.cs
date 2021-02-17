using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodDelivery.Views.LoginViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LogInContentViewModel _loginContent;

        public LoginView()
        {
            InitializeComponent();
            RegAccLabel_Click();
        }
        //private NavigationPage currentNavigation
        //{
        //    get => ((App)Application.Current).MainPage as NavigationPage;
        //}
        //public async Task ChangeRootPage(Page page)
        //{
        //    var root = currentNavigation.Navigation.NavigationStack[0];
        //    if (root == null)
        //    {
        //        await currentNavigation.Navigation.PushAsync(page);
        //        return;
        //    }
        //    currentNavigation.Navigation.InsertPageBefore(page, root);
        //    await PopToRootAsync();
        //}

        //public async Task PopToRootAsync()
        //{
        //    while (currentNavigation.Navigation.ModalStack.Count > 0)
        //    {
        //        await currentNavigation.Navigation.PopModalAsync(false);
        //    }
        //    while (currentNavigation.CurrentPage != currentNavigation.Navigation.NavigationStack[0])
        //    {
        //        await currentNavigation.PopAsync(false);
        //    }
        //}

        public void RegAccLabel_Click()
        {
            lbRegAcc.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    DisplayAlert("Working!", "label is working!", "OK");
                })
            });
        }
    }
}