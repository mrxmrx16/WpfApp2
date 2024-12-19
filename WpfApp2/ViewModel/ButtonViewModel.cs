using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp2.Service;

namespace WpfApp2.ViewModel
{
    internal class ButtonViewModel
    {
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new RelayCommand(obj =>
                    {
                        MessageBox.Show("");
                    }));
            }
        }
    }
}
