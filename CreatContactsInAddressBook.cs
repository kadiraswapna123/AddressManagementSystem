using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookManagementSystem
{
    internal class CreatContactsInAddressBook
    {
        private WriteAndReadToFile wtf;
        private List<Person> adressBookList = new List<Person>();
        public List<Person> AdressBookList
        {
            get { return adressBookList; }
            set { this.adressBookList = value; }
        }


        public AdressBook()
        {
            AdressBookList = new List<Person>();
            wtf = new WriteAndReadToFile();
        }

        // Create instance of Person-class and call AddPersonToList-method
        public void CreateUser()
        {
            Console.WriteLine("Enter firstName:");
            var firstName = Console.ReadLine();

            Console.WriteLine("Enter lastName:");
            var lastName = Console.ReadLine();

            Console.WriteLine("Enter adress:");
            var adress = Console.ReadLine();

            Console.WriteLine("Enter city");
            var city = Console.ReadLine();

            Console.WriteLine("Enter state");
            var state = Console.ReadLine();

            Console.WriteLine("Enter zip");
            var zip = Console.ReadLine();

            Console.WriteLine("Enter PhoneNumber");
            var PhonenNmber = Console.ReadLine();

            Console.WriteLine("Enter email");
            var email = Console.ReadLine();

            Person person = new Person(firstName, lastName, adress, city, state, zip, PhonenNmber, email);
            AddPersonToList(person);
            wtf.WriteUserToFile(person);

        }
    }
}
