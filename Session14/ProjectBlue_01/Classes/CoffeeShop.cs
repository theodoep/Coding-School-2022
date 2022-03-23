using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Classes
{
    public class CoffeeShop
    {
        public readonly string EmployeesFileName = "employees.json";
        public readonly string CustomerFileName = "customer.json";
        public readonly string ProductFileName = "products.json";
        public const string TRANS_STORAGE = "transStorage.json";

        public Customer SingleCustomer { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Product> Products { get; set; }
        public List<Product> Basket { get; set; }
        public List<TransactionLine> BasketL { get; set; }
        public List<Transaction> Transactions { get; set; }
        public int CustomerCode { get; set; } = 0;

        public CoffeeShop()
        {
            Employees = new List<Employee>();
            SingleCustomer = new Customer();
            Basket = new List<Product>();
            BasketL = new List<TransactionLine>();
            Transactions = new List<Transaction>();
        }


        public void SaveEmployees()
        {
            if (File.Exists(TRANS_STORAGE)) {
                LoadTransactions();
            }
            if (!CanAdd(Employees)) {
                string msg = "Can't add";
            }
            else {
                string jsonStr = JsonSerializer.Serialize(Employees);
                File.WriteAllText(EmployeesFileName, jsonStr);
            }
        }

        public bool LoadEmployees()
        {//returns true if successful load
            bool fileExists = File.Exists(EmployeesFileName);
            if (fileExists)
            {
                string jsonStr = File.ReadAllText(EmployeesFileName);
                Employees = JsonSerializer.Deserialize<List<Employee>>(jsonStr);
            }
            return fileExists;
        }

        public void SaveCustomer()
        {
            string jsonStr = JsonSerializer.Serialize(SingleCustomer);
            File.WriteAllText(CustomerFileName, jsonStr);
        }

        public bool LoadCustomer()
        {//returns true if successful load
            bool fileExists = File.Exists(CustomerFileName);
            if (fileExists)
            {
                string jsonStr = File.ReadAllText(CustomerFileName);
                SingleCustomer = JsonSerializer.Deserialize<Customer>(jsonStr);
            }
            return fileExists;
        }


        public void SaveProduct()
        {
            string jsonStr = JsonSerializer.Serialize(Products);
            File.WriteAllText(ProductFileName, jsonStr);
        }

        public bool LoadProduct()
        {//returns true if successful load
            bool fileExists = File.Exists(ProductFileName);
            if (fileExists)
            {
                string jsonStr = File.ReadAllText(ProductFileName);
                Products = JsonSerializer.Deserialize<List<Product>>(jsonStr);
            }
            return fileExists;
        }
        public void SaveTransaction() {
            if (File.Exists(TRANS_STORAGE)) {
                LoadTransactions();
            }
            string jsonStr = JsonSerializer.Serialize(Transactions);
            File.WriteAllText(TRANS_STORAGE, jsonStr);
        }
        public bool LoadTransactions() {
            bool fileExists = File.Exists(TRANS_STORAGE);
            if (fileExists) {
                string jsonStr = File.ReadAllText(TRANS_STORAGE);
                
                //ERROR: the json value could not be converted to system.collections.generic.list c# "list"
                
                Transactions = JsonSerializer.Deserialize<List<Transaction>>(jsonStr);
                
                //PROBLEM: returns only 1, and I can't add more than 1 transactions 
                //SOLUTION: Duplicated the 1st transaction

                //NEW PROBLEM: parameters don't match               
            }
            return fileExists;
        }

        public bool CanAdd(List<Employee> staff) {
            bool can = true;
            int _managerCount = 0;
            int _cashierCount = 0;
            int _waiterCount = 0;
            int _baristaCount = 0;
            foreach (Employee item in staff) {  
                if (item.EmployeeType == EmployeeType.Manager) { // should be 1 method
                    _managerCount++;
                }
                if (item.EmployeeType == EmployeeType.Cashier) {
                    _cashierCount++;
                }
                if (item.EmployeeType == EmployeeType.Waiter) {
                    _waiterCount++;
                }
                if (item.EmployeeType == EmployeeType.Barista) {
                    _baristaCount++;
                }
                return true;

                if (_managerCount > 1 ) {   // should be another method
                    //Error msg
                    return false;
                }
                if (_cashierCount > 2) {
                    //Error msg
                    return false;
                }
                if (_waiterCount > 2) {
                    //Error msg
                    return false;
                }
                if (_baristaCount > 3) {
                    //Error msg
                    return false;
                }

                if (_managerCount != 1) { //either new method or merge above
                    //Too few error msg
                    return false;
                }
                if (_cashierCount < 1) {
                    //Error msg
                    return false;
                }
                if (_waiterCount < 1) {
                    //Error msg
                    return false;
                }
                if (_baristaCount < 1) {
                    //Error msg
                    return false;
                }
            }
            return can;
        }
    }
}
