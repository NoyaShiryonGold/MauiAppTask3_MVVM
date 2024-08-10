using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTask2.Models
{
    public class User : ObservaleObject
    {
        private string? name;
        
        public string? Name
        {
            get => name;
            set { name = value; OnPropertyChanged(); }
        }

        private string? username;

        public string? UserName
        {
            get => username;
            set { username = value; OnPropertyChanged(); }
        }

        [MinLength(5, ErrorMessage = "Too short.")]
        [MaxLength(35, ErrorMessage = "Too long.")]
        [Required(ErrorMessage = "Email is required.")]
        private string? email;

        public string? Email
        {
            get => email;
            set { email = value; OnPropertyChanged(); }
        }

        private string? password;

        public string? Password
        {
            get => password;
            set { password = value; OnPropertyChanged(); }
        }

        private string? phone;

        public string? Phone
        {
            get => phone;
            set { phone = value; OnPropertyChanged(); }
        }

        private DateTime birthdate;

        public DateTime Birthdate
        {
            get => birthdate;
            set { birthdate = value; OnPropertyChanged(); OnPropertyChanged(nameof(Age)); }
        }

        public int Age
        {
            get
            {
                int now = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                int dob = int.Parse(birthdate.ToString("yyyyMMdd"));
                return (now - dob) / 10000;
            }
        }
    }
}
