using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    sealed class YearlyMember : Member
    {
        private double dues;

        public YearlyMember(string name, string address, string phone, double dues) : base(name, address, phone)
        {
            Dues = dues;
        }

        public override double Dues
        {
            get { return dues; }
            set { dues = value; }
        }

        public double WeeklyDues
        {
            get { return Dues / 52; }
        }

        public double MonthlyDues
        {
            get { return Dues / 12; }
        }

        public override string ToString()
        {
            return $"name: {Name}, address: {Address}, phone: {Phone}, dues: {Dues}, weeklyDues: {WeeklyDues}, monthlyDues: {MonthlyDues}";
        }
    }
}
