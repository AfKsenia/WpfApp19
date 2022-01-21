using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp19.Models;

namespace WpfApp19.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnotifyPropertyChanged([CallerMemberName] string PropertyName=null)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
        private double number1;
        public double Number1
        {
            get => number1;
            set
            {
                number1 = value;
                OnotifyPropertyChanged();
            }
        }
        private int number2;
        //public int Number2
        //{
        //    get => number2;
        //    set
        //    {
        //        number2 = value;
        //        OnotifyPropertyChanged();
        //    }
        //}
        private double number3;
        public double Number3
        {
            get => number3;
            set
            {
                number3 = value;
                OnotifyPropertyChanged();
            }
        }
        // команда вместо обработчика события;
        public ICommand AddCommand { get; }
        private void OnAddCommandExecute(object p)
        {
            Number3 = Radius.Add(Number1);
        }
        private bool CanAddCommandExecute(object p)
        {
            if (Number1!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public MainWindowViewModel()
        {
            AddCommand = new RelayCommand(OnAddCommandExecute, CanAddCommandExecute);
        }
    }
}
