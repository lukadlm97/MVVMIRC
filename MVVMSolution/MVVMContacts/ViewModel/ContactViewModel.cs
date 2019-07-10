using MVVMContacts.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace MVVMContacts.ViewModel
{
    public class ContactViewModel
    {
        
        public ContactViewModel()
        {
           
        }

        private ContactModel _currentContact;

        public ContactModel CurrentContact
        {
            get { return _currentContact; }
            set { _currentContact = value; }
        }

        
        public bool CanDelete { get { return } }
        public DeleteCommand Delete { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }
    }
}
