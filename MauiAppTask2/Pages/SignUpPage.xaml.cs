using MauiAppTask2.Models;

namespace MauiAppTask2.Pages;

public partial class SignUpPage : ContentPage
{
    private User user=null;
    public SignUpPage()
    {
        InitializeComponent();
        user = new User
        {
            Name = "Noye Lerner Shiryon",
            UserName = "noya",
            Birthdate = new DateTime(1978, 10, 10),
            Email = "noya.shiryon@gmail.com",
            Phone = "0537399556",
            Password = "1234$ABcd"
        };
        this.BindingContext = user;        
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        string name=(sender as Entry).Placeholder.ToString();
        string value=(sender as Entry).Text;
        Label errorLbl=null;
        bool isValid=true;
        switch (name)
        {
            case "Username":
                isValid = ValidateUsername(value);
                errorLbl = errlblUserName;
                break;
            case "Password":
                isValid = ValidatePassword(value);
                errorLbl = errlblPassword;
                break;
            case "Confirm password":
                isValid = entConfirm.Text.Equals(entPassword.Text);
                errorLbl = errlblPassword;
                break;
            case "Birthdate":
                isValid = user.Age<18;
                errorLbl = errlblDate;
                break;
            default:
                break;
        }

        if (errorLbl == null) return;
        errorLbl.Text = !isValid ? name +" is invalid" : null;
        errorLbl.IsVisible = !isValid;
    }
    private bool ValidateName(string value)
    {
        if (char.IsDigit(value[0])) return false;
        if (value.Length<3) return false;
        if (value.Length>30) return false;
        return true;
    }
    private bool ValidateUsername(string value)
    {
        if (char.IsDigit(value[0])) return false;
        if (value.IndexOf(" ")!=-1) return false;
        if (value.Length<5) return false;
        return true;
    }
    private bool ValidatePassword(string value)
    {
        bool digit = false, upper = false, lower = false, symbol = false;
        foreach (char c in value)
        {
            if (char.IsDigit(c)) digit = true;
            if (char.IsUpper(c)) upper= true;
            if (char.IsLower(c)) lower = true;
            if (char.IsPunctuation(c)) symbol = true;
        }
        return digit && upper && lower && symbol;
    }
}