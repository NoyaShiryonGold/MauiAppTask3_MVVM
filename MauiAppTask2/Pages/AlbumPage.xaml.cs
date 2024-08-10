namespace MauiAppTask2.Pages;

public partial class AlbumPage : ContentPage
{
    int num = 1;
    string[] images = ["a1.jpg", "a2.jpg", "a3.jpg", "a4.jpg", "a5.jpg"];
    public AlbumPage()
    {
        InitializeComponent();
        PreBtn.IsEnabled = false;
    }
    private void OnArrowClicked(object sender, EventArgs e)
    {
        if (sender == PreBtn)
        {
            if (num > 0)
            {
                num--;
                ImageHolder.Source = images[num];
            }
        }
        else
        {
            if (num < images.Length - 1)
            {
                num++;
                ImageHolder.Source = images[num];
            }
        }
        PreBtn.IsEnabled = num > 0;
        NextBtn.IsEnabled = num < images.Length - 1;
        //SemanticScreenReader.Announce(CounterBtn.Text);
    }
}