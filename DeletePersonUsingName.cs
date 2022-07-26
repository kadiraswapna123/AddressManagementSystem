using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookManagementSystem
{
    internal class DeletePersonUsingName
    {
        private ArrayList<Person> friend = new ArrayList<Person>();

        public boolean deleteFriend(String Mike)
        {
            for (Person p : friend)
            {
                if (p.name.equals(Mike))
                {
                    p.friend.remove(Mike);
                    break;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
