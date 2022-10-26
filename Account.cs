using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Bank_accounting_system.Models
{
    class Account
    {
      private  int _customerID;
        private int _numberAccount=0;
      private double _balance=0;
      private double _credit=0;
      private bool flag = false;

        public Account(int customerID,int numberAccount,double balance,double credit)
        {
            this._customerID = customerID;
            this._numberAccount = numberAccount;
            this._balance = balance;
            this._credit = credit;
        }

        public int CustomerId
        {
            get { return this._customerID; }

            set
            {

                if (CheckingID2(value))
                {
                    _customerID = value;
                }
                else
                {
                    Console.WriteLine("הוכנסו תווים לא תקינים");
                }

            }

        }
        public int NumberAccount
        {
            get { return this._numberAccount; }

            set
            {

                if (CheckingID2(value))
                {
                    _numberAccount = value;
                }
                else
                {
                    Console.WriteLine("הוכנסו תווים לא תקינים");
                }

            }

        }
        public double Balance
        {
            get { return this._balance; }

            set
            {

                if (CheckingID(value))
                {
                    _balance = value;
                }
                else
                {
                    Console.WriteLine("הוכנסו תווים לא תקינים");
                }

            }

        }
        public double Credit
        {
            get { return this._credit; }

            set
            {

                if (CheckingID(value))
                {
                    _credit = value;
                }
                else
                {
                    Console.WriteLine("הוכנסו תווים לא תקינים");
                }

            }

        }




        private bool CheckingID2(int customerID)
        {
            string _customerID = customerID.ToString();
            if (_customerID != null)
            {
                if (_customerID.Length < 9)
                {


                    flag = IsDigitsOnly(_customerID);
                    return flag;


                }

            }

            return flag;
        }


        private bool CheckingID(double customerID)
        {
            string _customerID = customerID.ToString();
            if (_customerID != null)
            {
                if (_customerID.Length < 9)
                {


                    flag = IsDigitsOnly(_customerID);
                    return flag;


                }

            }

            return flag;
        }



        private bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return flag;
            }

            flag = true;
            return flag;
        }


        public override string ToString()
        {
            return "Customer ID: " + this._customerID +
                    " Numbe rAccount:  " + this._numberAccount +
                    " Balance  " + this._balance +
                    " Credit:  " + this._credit;
                    
        }
    }
}
