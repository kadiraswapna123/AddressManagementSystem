using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookManagementSystem
{
    internal class EditContactUsingName
    {
        private void AddContactToGroup_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Lync.Controls.SearchResult selectedContact = (Microsoft.Lync.Controls.SearchResult)ResultList.SelectedItem;
            if (selectedContact.Result.GetType().Name == "Contact")
            {
                Contact contact = selectedContact.Result as Contact;
                selectedGroup.BeginAddContact(contact, (ar) => { selectedGroup.EndAddContact(ar); }, null);

            }
        }
    }
}

