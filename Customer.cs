using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Bank_accounting_system.Models
{
    class Customer
    {
      private  int _customerId=0;
      private string _fname;
      private string _lname;
      private string _address;
      private string _phone;
      private string _areaCode;
      private DateTime _Dateofbirth;
      private bool flag=false;

        public Customer(int customerId, string fname,string lname,string address,string phone,string areaCode,DateTime Dateofbirth)
        {
            this._customerId = customerId;
            this._fname = fname;
            this._lname = lname;
            this._address = address;
            this._phone = phone;
            this._areaCode = areaCode;
            this._Dateofbirth = Dateofbirth;
        }

        public int CustomerId
        {
            get { return this._customerId; }

            set {

              if(  CheckingID(value))
                {
                    _customerId = value;
                }
              else
                {
                    Console.WriteLine("הוכנסו תווים לא תקינים");
                }
                
            }
                
        }
        public string FirstName
        {
            get { return this._fname; }
            set {

                if (CheckingNames(value))
                    { _fname = value; }
                else { Console.WriteLine("הוכנסו תווים לא תקינים"); }

                

            }
                



        }
        public string LastName
        {
            get { return this._lname; }
            set {

                if(CheckingNames(value))
                {
                    _lname = value;
                }
                else
                {
                    Console.WriteLine("הוכנסו תווים לא תקינים");
                }
                
            }
        }
        public string Address
        {
            get { return this._address; }
            set {

                if (CheckingAddress(value))
                { _address = value; }
                else { Console.WriteLine("הוכנסו תווים לא תקינים"); }
            }
        }
        public string Phone
        {
            get { return this._phone; }
            set {
                if (CheckingPhone(value)) { _phone = value; }
                else { Console.WriteLine("הוכנסו תווים לא תקינים"); }
                
            }
        }
        public string AreaCode
        {
            get { return this._areaCode; }
            set { _areaCode = value; }
        }
        public DateTime Dateofbirth
        {
            get { return this._Dateofbirth; }
            set { _Dateofbirth = value; }
        }

        private bool CheckingID(int customerID)
        {
            string _customerID = customerID.ToString();
            if (_customerID !=null )
            {
                if(_customerID.Length<9)
                {


                    flag = IsDigitsOnly(_customerID);
                    return flag;


                }
                
            }

            return flag;
        }

        private bool CheckingNames(string name)
        {
            if(name !=null)
            {
                if (name.Length < 20) {
                    flag = IsDigitsOnly(name);
                    return flag;
                }
            }

            return flag;
        }
        private bool CheckingAddress(string address)
        {
            if(address.Length<20 && address!=null)
            { return flag = true; }
            return flag;
        }

        private bool CheckingPhone(string phone)
        {
            if(phone != null && phone.Length==10)
            {
                flag = IsDigitsOnly(phone);
            }
            return flag;
        }

     private   bool IsDigitsOnly(string str)
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
            return "Customer ID: " +this._customerId +
                    " First name:  "+ this._fname +
                    " Last name:  " + this._lname +
                    " Address:  " + this._address +
                    "Phone number: "+ this._areaCode + "-" + this._phone +
                    "Date of birth" +this._Dateofbirth;
        }

    }
}
