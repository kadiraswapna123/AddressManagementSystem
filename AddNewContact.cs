using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookManagementSystem
{
    internal class AddNewContact
    {
        static void Main(string[] args)
        {
            string selection = "";
            AddressPrompt prompt = new AddressPrompt();

            prompt.displayMenu();
            while (!selection.ToUpper().Equals("Q"))
            {
                Console.WriteLine("Selection: ");
                selection = Console.ReadLine();
                prompt.performAction(selection);
            }
        }

        void performAction(string selection)
        {
            string name = "";
            string address = "";
            string contact = 
                    Console.WriteLine("Enter Name: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter Address: ");
                    address = Console.ReadLine();
                    if (book.add(contact))
                    {
                        Console.WriteLine("contact successfully added!");
                    }
                    else
                    {
                        Console.WriteLine("An contact is already on file for {0}.", AddNewContact);
                    }
}
