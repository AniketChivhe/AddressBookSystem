using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Welcome To Adderess Book Program-------------");
            AddressBookSystem.UC1UC2_CreateAndAddingContacts.GetContact();
            AddressBookSystem.UC1UC2_CreateAndAddingContacts.ListContact();
        }
    }
}