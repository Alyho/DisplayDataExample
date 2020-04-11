using System.ComponentModel;
using TestApp.DataLayer;

namespace TestApp.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        DataDisplayExample.Models.IData data = new Data();
        private DataDisplayExample.User _user;
        private string _userName;
        private string _userAddress;

        public MainPageViewModel()
        {
            _user = data.GetUser(1);
            
            _userName = _user.Name;
            _userAddress = _user.Address;

        }

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                if (_userName !=value)
                {
                    _userName = value;
                    var args = new PropertyChangedEventArgs(nameof(UserName));

                    PropertyChanged?.Invoke(this, args);
                }
            }
        }

        public string UserAddress
        {
            get
            {
                return _userAddress;
            }
            set
            {
                if (_userAddress != value)
                {
                    _userAddress = value;
                    var args = new PropertyChangedEventArgs(nameof(UserAddress));

                    PropertyChanged?.Invoke(this, args);
                }
            }
        }



    }
}
