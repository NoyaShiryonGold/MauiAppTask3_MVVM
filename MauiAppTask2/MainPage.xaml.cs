 namespace MauiAppTask2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(MauiAppTask2.Pages.SignInPage));
        }

        private async void Signup_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(MauiAppTask2.Pages.SignUpPage));
        }

        private async void Album_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(MauiAppTask2.Pages.AlbumPage));
        }
    }

}
