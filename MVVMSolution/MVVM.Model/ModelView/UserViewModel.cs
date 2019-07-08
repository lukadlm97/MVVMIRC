using MVVMPro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM.Model.ModelView
{
    class UserViewModel
    {
        private IList<User> _UsersList;

        public UserViewModel()
        {
            _UsersList = new List<User>
            {
                new User{Username="Abc",Age=22,Country="Serbia"},
                new User{Username="Cba",Age=23,Country="Serbia"},
                new User{Username="Bac",Age=24,Country="Serbia"}
            };
        }


        public IList<User> Users
        {
            get { return _UsersList; }
            set { _UsersList = value; }
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
            set
            {
                mUpdater = value;
            }
        }

    }
}
