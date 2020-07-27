using System.ComponentModel;
using Xamarin.Forms;
using Intercom.Forms;

namespace IntercomFormsTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            CrossIntercomService.Current.RegisterUserWithUserId("123456");
            CrossIntercomService.Current.PresentMessenger();
        }
    }
}
