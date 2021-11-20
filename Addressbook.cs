using System;
using System.Collections.Generic;
using System.Text;

namespace day23_Addressbook
{
    class Addressbook

    {
        public readonly Contacts[] contacts;

        public Addressbook()
        {
            contacts = new Contacts[2]; ;
        }
        //uc3
        public void AddEntry(string name, string address)
        {
            Contacts AddContact = new Contacts(name, address);
            if (CheckEntry(name))
            {
                for (int i = 0; i < contacts.Length; i++)
                {
                    if (contacts[i] == null)
                    {
                        contacts[i] = AddContact;
                        Console.WriteLine("Address Book updated. {0} has been added!", name);
                        break;
                    }
                }

            }
        }
        //uc4
        private string existingContact = "";

        private bool CheckEntry(string name)
        {
            foreach (Contacts contact in contacts)
            {
                if (contact == null)
                {
                    break;
                }
                else if (contact != null && contact.ToString() != name)
                {
                    continue;
                }
                else if (contact.ToString() == name)
                {
                    existingContact = contact.ToString();
                    return false;
                }

            }
            return true;
        }
        //uc5

        public void RemoveEntry(string name)
        {
            if (!(CheckEntry(name)))
            {
                existingContact = null;
                Console.WriteLine("{0} removed from contacts", name);
            }
        }
        //uc6

        public string View()
        {
            string contactList = "";
            foreach (Contacts contact in contacts)
            {
                if (contact == null)
                {
                    break;
                }
                contactList += String.Format("Name: {0} -- Address: {1}" + Environment.NewLine, contact.Name, contact.Address);
            }
            return contactList;
        }
    }
}
    

