using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    abstract class Member
    {
        private string name;
        private string address;
        private string phone;

        protected Member(string name, string address, string phone)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public abstract double Dues
        {
            get;
            set;
        }

        public override string ToString()
        {
            return $"name: {name}, address: {address}, phone: {phone}, dues: {Dues}";
        }
    }
}
