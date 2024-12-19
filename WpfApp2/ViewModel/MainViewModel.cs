using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp2.ViewModel
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private List<Button> listButton;
        public List<Button> ListButton
        {
            get { return listButton; }
            set 
            { 
                listButton = value;
                OnPropertyChanged("ListButton");
            }
        }

        public MainViewModel()
        {
            ListButton = new List<Button>();

            for (int i=0; i<10; i++)
            {
                Button button = new Button();
                button.Name = "";
                ButtonViewModel buttonView = new ButtonViewModel();
                button.DataContext = buttonView;
                button.Command = buttonView.AddCommand;
                button.Margin = new Thickness(20, 20, 20, 20);
                ListButton.Add(button);
            }

        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
