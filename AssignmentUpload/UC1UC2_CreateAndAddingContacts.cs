﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class UC1UC2_CreateAndAddingContacts   
    {
        public static List<Person> People = new List<Person>();
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Addresses { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string PhoneNumber { get; set; }
            public string ZipCode { get; set; }
            public string EmailId { get; set; }
            public string PhoneNum { get; set; }

        }
        public static void GetContact()
        {
            Person person = new Person();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Address : ");
            person.Addresses = Console.ReadLine();

            Console.Write("Enter City : ");
            person.City = Console.ReadLine();

            Console.Write("Enter State : ");
            person.State = Console.ReadLine();

            Console.Write("Enter ZipCode: ");
            person.ZipCode = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNum = Console.ReadLine();

            Console.Write("Enter EmailId: ");
            person.EmailId = Console.ReadLine();
            People.Add(person);
        }
        public static void PrintContact(Person person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Address : " + person.Addresses);
            Console.WriteLine("City : " + person.City);
            Console.WriteLine("State : " + person.State);
            Console.WriteLine("ZipCode : " + person.ZipCode);
            Console.WriteLine("Phone Number: " + person.PhoneNum);
            Console.WriteLine("EmailId: " + person.EmailId);
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------");
        }
        public static void ListContact()
        {
            if (People.Count == 0)
            {
                Console.WriteLine("Your address book is empty.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("The Contacts In address book:\n");
            foreach (var person in People)
            {
                PrintContact(person);
            }
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}
