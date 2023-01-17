using InvoiceRegister22.Commands;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace InvoiceRegister22.MVVM.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _selectedView;
      
        public BaseViewModel SelectedView
        {
            get { return _selectedView; }
            set
            {
                _selectedView = value;
                OnPropertyChanged(nameof(SelectedView));
            }
        }

        public MainViewModel()
        {

        }

       
    }
    
}
