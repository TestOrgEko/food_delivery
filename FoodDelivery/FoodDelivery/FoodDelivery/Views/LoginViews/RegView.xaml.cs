using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont(@"Fonts\SF-Pro-Regular.ttf", Alias = "SF-Pro-Regular")]

namespace FoodDelivery.Views.LoginViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegView : ContentPage
    {
        public RegView()
        {
            InitializeComponent();
        }
    }
}