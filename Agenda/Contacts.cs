using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Contacts
    {
        private string name;

        public string _name
        {
            get { return name; }
            set { name = value; }
        }
        private string Telephone;

        public string _Telephone
        {
            get { return Telephone; }
            set { Telephone = value; }
        }
        private string Cellphone;

        public string _Cellphone
        {
            get { return Cellphone; }
            set { Cellphone = value; }
        }
        private Adress Adress;

        public Adress _Adress
        {
            get { return Adress; }
            set { Adress = value; }
        }
        public static List<Contacts> ContactList = new List<Contacts>();

        

        

    }
}
