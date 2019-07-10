using MVVMNames.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMNames.ViewModel
{
    public class UserViewModel
    {
        private ObservableCollection<UserModel> _usersList;

        public ObservableCollection<UserModel> UserList
        {
            get { return _usersList; }
            set { _usersList = value; }
        }

        
        public UserViewModel()
        {
            _usersList = new ObservableCollection<UserModel> {
                new UserModel { UserID=1,FirstName="Luka",LastName="Radovanovic",Country="SRB"},
                new UserModel { UserID=2,FirstName="Luka",LastName="Radovanovic",Country="AVG"},
                new UserModel { UserID=3,FirstName="Luka",LastName="Radovanovic",Country="USA"}
            };
        }

        private ICommand mUpdater;

        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set { mUpdater = value; }
        }

        public void AddItem()
        {
            
        }

        private class Updater : ICommand
        {
            public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                throw new NotImplementedException();
            }

            public void Execute(object parameter)
            {
                throw new NotImplementedException();
            }
        }
    }
}
