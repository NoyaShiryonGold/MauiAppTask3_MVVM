using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppTask2.Models
{
    //מחלקת בסיס לשינוי בערך תכונה
    public class ObservaleObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]string propertyName=null)
        {
            //אם משהו נרשם לאירוע, כלומר רצה לדעת אם התכונה השתנתה
            //לכן, תפעיל את האירוע, ותשלח כפרמטר את השם של התכונה שהתשתנה
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
