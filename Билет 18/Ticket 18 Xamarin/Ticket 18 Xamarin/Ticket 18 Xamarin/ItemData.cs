using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace Ticket_18_Xamarin
{
    public class ItemData : INotifyPropertyChanged
    {
        private int count;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        { 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ImageSource Image { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int Count
        {
            get => count;
            set
            {
                if (count != value && value >= 0)
                {
                    count = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
