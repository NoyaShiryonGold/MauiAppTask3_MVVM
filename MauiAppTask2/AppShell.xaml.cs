namespace MauiAppTask2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MauiAppTask2.Pages.SignUpPage), typeof(MauiAppTask2.Pages.SignUpPage));
            Routing.RegisterRoute(nameof(MauiAppTask2.Pages.SignInPage), typeof(MauiAppTask2.Pages.SignInPage));
            Routing.RegisterRoute(nameof(MauiAppTask2.Pages.AlbumPage), typeof(MauiAppTask2.Pages.AlbumPage));
        }
    }
}
