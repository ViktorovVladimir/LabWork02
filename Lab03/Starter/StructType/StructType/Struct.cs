




using System;


namespace MyWorkSpaceStruct
{
    public enum AccountType { Checking, Deposit }

    public struct BankAccount
    {
        public long accNo;
        public decimal accBal;
        public AccountType accType;
    }

    public class Program
    {
        public static void Main()
        {   
            BankAccount goldAccount;

            goldAccount.accType = AccountType.Checking;
            goldAccount.accBal = (decimal)3200.00;
            //goldAccount.accNo = 123;

            //--.            
            Console.WriteLine("Enter account number: ");
            goldAccount.accNo = long.Parse( Console.ReadLine() );

            //--.
            Console.WriteLine("Acct Number {0}", goldAccount.accNo);
            Console.WriteLine("Acct Type {0}", goldAccount.accType);
            Console.WriteLine("Acct Balance ${0}", goldAccount.accBal);
        }
    }
}




