using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FoodDelivery.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {

        protected bool isBusy;
        public bool IsBusy
        {
            get => isBusy;
            set => Set(ref isBusy, value);
        }
        public bool IsInitialized => !IsBusy;

        protected INavigation Navigation { get; set; }

        private NavigationPage currentNavigation
        {
            get => ((App)Application.Current).MainPage as NavigationPage;
        }

        public async Task ChangeRootPage(Page page)
        {
            var root = currentNavigation.Navigation.NavigationStack[0];
            if (root == null)
            {
                await currentNavigation.Navigation.PushAsync(page);
                return;
            }
            currentNavigation.Navigation.InsertPageBefore(page, root);
            await PopToRootAsync();
        }

        public async Task PopToRootAsync()
        {
            while (currentNavigation.Navigation.ModalStack.Count > 0)
            {
                await currentNavigation.Navigation.PopModalAsync(false);
            }
            while (currentNavigation.CurrentPage != currentNavigation.Navigation.NavigationStack[0])
            {
                await currentNavigation.PopAsync(false);
            }
        }

        public BaseViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            this.isBusy = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void Set<T>(ref T field, T newValue, [CallerMemberName] string propName = null)
        {
            if (!EqualityComparer<T>.Default.Equals(field, newValue))
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
