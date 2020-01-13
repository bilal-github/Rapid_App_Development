/*
 * Author: Bilal Ahmad
 * Description: Lab 2
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public static class CustomerDB
    {
        //local variables
        const string path = "customers.txt"; //located in bin/debug directory

        //method to save the list of customer data to a file
        public static void SaveCustomers(List<Customer> customersList)
        {
            using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    foreach (Customer customer in customersList)
                    {
                        streamWriter.WriteLine(customer.ToCSV());
                    }
                }
            }
        }

        //method to read the list of customer data from a file to the listbox
        public static List<Customer> ReadCustomers()
        {
            List<Customer> customers = new List<Customer>();//create empty list

            Customer customer;// reading customers
            string line; // next line from the file
            string[] fields; // line broken into fields

            int accountNo = 0;
            string customerName = "";
            string customerType = "";
            decimal chargeAmount;

            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    while (!streamReader.EndOfStream)
                    {
                        line = streamReader.ReadLine();
                        fields = line.Split(','); // split on commas

                        //asign the data to variables
                        accountNo = Convert.ToInt32(fields[0]);
                        customerName = fields[1];
                        customerType = fields[2];
                        chargeAmount = Convert.ToDecimal(fields[3]);

                        //checking which customer is in the read line.
                        if (fields[2] == "R")
                        {
                            customer = new ResidentialCustomer(accountNo, customerName, customerType, chargeAmount);
                        }
                        else if (fields[2] == "C")
                        {
                            customer = new CommercialCustomer(accountNo, customerName, customerType, chargeAmount);
                        }
                        else
                        {
                            customer = new IndustrialCustomer(accountNo, customerName, customerType, chargeAmount);
                        }
                        customers.Add(customer);
                    }
                }
            }

            return customers;
        }

    }
}
