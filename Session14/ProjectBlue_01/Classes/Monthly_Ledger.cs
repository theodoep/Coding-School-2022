using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Classes
{
    public class Monthly_Ledger
    {
        private const double Rent = 3000;

        public int Year { get; set; }
        public int Month { get; }
        public double Income { get; }
        public double Expences { get; }
        public double Total { get; }
        public List<Transaction> Transactions { get; }

        public Monthly_Ledger()
        {

        }

        public string GetReport(int month, double income, double expenses, int year)
        {
            return "Month: " + month + "\nIncome: " + income + "\nExpenses: " + expenses + "\nTotal: ";
        }
        //public string GetWhen(DateTime date) {
        //    return date.Month.ToString();
        //}

        Transaction _trans = new Transaction();
        public void LoadTransactions()
        {

            string s = File.ReadAllText(Transaction.TRANS_STORAGE);

            _trans = (Transaction)JsonSerializer.Deserialize(s, typeof(Transaction));
        }

        public void GetMonthlyReport(DateTime date)
        {
            //string month = GetWhen(date);
            LoadTransactions();

            Transaction _monthlyTrans = new Transaction();

            foreach (Transaction item in _trans.Transactions)
            {
                if (_trans.Date.Month.Equals(date.Month) && _trans.Date.Year.Equals(date.Year))
                {
                    _monthlyTrans.Transactions.Add(item);
                }
            }
        }

        public double CalculateCost(List<Transaction> transList)
        {
            double cost = 0;
            for (int i = 0; i < transList.Count; i++)
            {
                cost += transList[i].TransCost;
            }
            return cost;
        }

        public double CalculateIncome(List<Transaction> transList)
        {
            double income = 0;
            for (int i = 0; i < transList.Count; i++)
            {
                income += transList[i].TotalPrice;
            }
            return income;
        }

        public double CalculateSalaries(List<Employee> employees)
        {
            double salaries = 0;
            for (int i = 0; i < employees.Count; i++)
            {
                salaries += employees[i].SalaryPerMonth;
            }
            return salaries;
        }

        public double CalculateMonthProfit(List<Transaction> transList, List<Employee> employees)
        {
            double monthProfit = 0;
            monthProfit = CalculateIncome(transList) - CalculateCost(transList) - CalculateSalaries(employees) - Rent;
            return monthProfit;
            //return CalculateIncome(transList) - CalculateCost(transList) - CalculateSalaries(employees) - Rent;
        }

    }
}
