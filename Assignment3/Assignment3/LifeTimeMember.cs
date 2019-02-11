using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    sealed class LifeTimeMember : Member
    {
        private double dues;
        private double discount;

        public LifeTimeMember(string name, string address, string phone, double dues) : base(name, address, phone)
        {
            Dues = dues;
        }

        public double Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public override double Dues
        {
            get { return dues; }
            set
            {
                if (value > 0)
                {
                    Discount = value * 0.15;
                    dues = value - Discount;
                }
            }
        }

        public override string ToString()
        {
            return $"name: {Name}, address: {Address}, phone: {Phone}, dues: {Dues}, discount: {Discount}";
        }
    }
}
