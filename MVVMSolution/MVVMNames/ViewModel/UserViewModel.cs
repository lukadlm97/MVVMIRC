using MVVMNames.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMNames.ViewModel
{
    public class UserViewModel
    {
        private ObservableCollection<UserModel> _usersList = new ObservableCollection<UserModel>();

        public ObservableCollection<UserModel> UserList
        {
            get { return _usersList; }
            set { _usersList = value; }
        }

        
        public UserViewModel()
        {
            int _id;
            string _firstName;
            string _lastName;
            string _country;
            using(SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Luka\Documents\UsersDB.mdf; Integrated Security = True; Connect Timeout = 30"))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();

                string query = "select* from dbo.users";

                command.CommandText = query;

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    _id = (int)reader["Id"];
                    _firstName = reader["firstName"].ToString();
                    _lastName = reader["lastName"].ToString();
                    _country = reader["country"].ToString();
                    UserModel u = new UserModel(_id,_firstName,_lastName,_country);
                    _usersList.Add(u);
                }
                connection.Close();
            }
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
            int _id;
            string _firstName;
            string _lastName;
            string _country;
            

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
