using System;

class MainClass {
  public static void Main (string[] args) {
    
    Console.WriteLine("Testing Code for Savings Account");
    SavingsAccount savings = new SavingsAccount();
    savings.Deposit(2000);
    savings.Withdraw(5000);
    savings.CalculateInterest();
    savings.Withdraw(500);

    
    Console.WriteLine("Testing Code for Checkings Account");
    CheckingAccount checking = new CheckingAccount();
    checking.Deposit(2000);
    checking.Withdraw(5000);
    checking.CalculateInterest();
    checking.Withdraw(500);

  }
}