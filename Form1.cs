using My_Bank_accounting_system.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Bank_accounting_system
{
    public partial class Form1 : Form
    {
        // private Customer[] customers = new Customer[100];
        private List<Customer> customers = new List<Customer>();

       // private Account[] accounts = new Account[100];
        private List<Account> accounts = new List<Account>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

            string  fname, lname, addres, phone, areaCode;
            DateTime dd;
            int id;
            id =Convert.ToInt32( txtCustomerID.Text);
            fname = txtFname.Text;
            lname = txtFname.Text;
            addres = txtAdd.Text;
            phone = txtPhone.Text;
            areaCode = comboBoxAreaCode.Text;
            dd = Dateofbirth.Value;
            Customer c = new Customer(id,fname,lname,addres,phone,areaCode, dd);
            AddCustomerToArray(c);




        }

        private void AddCustomerToArray(Customer c)
        {/*
            for (int i = 0; i < customers.Length; i++)
            {
                if(customers[i]==null)
                {
                    customers[i] = c;
                }
            }*/
            string fname, lname, addres, phone, areaCode;
            DateTime dd;
            int id;
            id = Convert.ToInt32(txtCustomerID.Text);
            fname = txtFname.Text;
            lname = txtFname.Text;
            addres = txtAdd.Text;
            phone = txtPhone.Text;
            areaCode = comboBoxAreaCode.Text;
            dd = Dateofbirth.Value;
            Customer c1 = new Customer(id, fname, lname, addres, phone, areaCode, dd);
            c = c1;
            customers.Add(c);
        }

        private void btnCreatnewAccount_Click(object sender, EventArgs e)
        {
            
            int numacc,cusId;
            double balance = 0, credit;
            numacc = Convert.ToInt32(txtNumberAccount.Text);
            cusId = Convert.ToInt32( txtCustomerID.Text);
            credit = Convert.ToDouble(txtCredit.Text);

            Account a = new Account(cusId, numacc, balance, credit);
            AddAccount(a);
        }

        private void AddAccount(Account a)
        {/*
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = a;
                }
            }
            */
            int numacc, cusId;
            double balance = 0, credit;
            numacc = Convert.ToInt32(txtNumberAccount.Text);
            cusId = Convert.ToInt32(txtCustomerID.Text);
            credit = Convert.ToDouble(txtCredit.Text);

            Account a1 = new Account(cusId, numacc, balance, credit);
            a = a1;
            accounts.Add(a);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            double deposit = 0;
            int numacc;
            Account a;
            deposit = Convert.ToDouble(txtSumDeposit.Text);
            numacc = Convert.ToInt32(txtNumberAccount.Text);
            DeposittAcc(numacc, deposit);

        }
        /*
        private Account RutrneAcc(int numberacc)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if(numberacc==accounts[i].NumberAccount)
                {
                    accounts[i].Balance=
                }
            }
        }*/

        private void DeposittAcc(int numberacc,double dep)
        {
           // int temp = ReturnAcc(numberacc);

            //for (int i = 0; i < accounts.Length; i++)
            //{
            //    if(numberacc== accounts[i].NumberAccount)
            //    {
            //        accounts[i].Balance += dep;
            //    }
            //}

            foreach (Account a in accounts)
            {
                if(numberacc==a.NumberAccount)
                {
                    a.Balance += dep;
                }
            }
           
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            int numberacc = Convert.ToInt32(txtNumberAccount.Text);
            double sumWithdraw = Convert.ToDouble(txtSumWithdraw.Text);
            WithdrawAcc(numberacc, sumWithdraw);

        }
        private Account ReturnAcc(int num)
        {
            //for (int i = 0; i < accounts.Length; i++)
            //{
            //    if(num==accounts[i].Balance)
            //    {
            //        return num;
            //    }
            //}
            //return -1;

            foreach (Account item in accounts)
            {
                if(num==item.NumberAccount)
                {
                    return item;
                }
            }
            return null;
        }

        private void WithdrawAcc(int numberacc, double sum)
        {

            //for (int i = 0; i < accounts.Length; i++)
            //{
            //    if (numberacc == accounts[i].NumberAccount)
            //    {
            //        accounts[i].Balance -= sum;
            //    }
            //}
            foreach (Account item in accounts)
            {
                if(numberacc==item.NumberAccount)
                {
                    item.Balance -= sum;
                }
            }

        }
        /*
        private void txtSumAcc_TextChanged(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumberAccount);
            for (int i = 0; i < accounts.Length; i++)
            {
                if(num==accounts[i].NumberAccount)
                {
                    txtSumAcc.Text=(accounts[i].Balance).ToString();
                }
            }
        }
        */
        private void buttonshow_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumberAccount.Text);
            //for (int i = 0; i < accounts.Length; i++)
            //{
            //    if (num == accounts[i].NumberAccount)
            //    {
            //        txtSumAcc.Text = (accounts[i].Balance).ToString();
            //    }
            //}
            foreach (Account item in accounts)
            {
                if(num==item.NumberAccount)
                {
                    txtSumAcc.Text = (item.Balance).ToString();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtCustomerID.Text);
            Customer c= RCustomer(num);
            if (CustomerExit(num))
            {
                txtExist.Text = "לקוח קיים";
                comboBox1.Text = c.ToString();
            }
            else
            {
                txtExist.Text = "";
            }
           

        }
        private bool CustomerExit(int num)
        {/*
            for (int i = 0; i < customers.Length; i++)
            {
                if (num==customers[i].CustomerId)
                {
                    return true;
                }
            }
            return false;*/
            foreach (Customer c in customers)
            {
                if(customers.Equals(num))
                {
                    return true;
                }
            }

            return false;
        }

        private Customer RCustomer(int num)
        {/*
            for (int i = 0; i < customers.Length; i++)
            {
                if (num == customers[i].CustomerId)
                {
                    return customers[i];
                }
            }
            return null;*/
            foreach (Customer c in customers)
            {
                if (customers.Equals(num))
                {
                    return c;
                }
            }
            return null;
        }

        private void btnShowde_Click(object sender, EventArgs e)
        {
            int customerid = Convert.ToInt32(txtCustomerID.Text);
            int accNum = Convert.ToInt32(txtCustomerID.Text);
            Customer c1 = RCustomer(customerid);
            if(c1==null)
            {
                AddCustomerToArray(c1);
            }
            Account a = ReturnAcc(accNum);
            if (a == null)
            {
                AddAccount(a);
            }
            textBox1.Text = c1.ToString();
           // textBox2.Text = a.ToString();
           
            
            //c.Show();
            
            
            
            
        }

        
    }
}
