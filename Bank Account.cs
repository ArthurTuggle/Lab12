using System;
abstract class BankAccount{
  
  public string AcctNbr {get; set;}
  public string Name {get; set;}
  public double Balance {get; set;}
  public DateTime DateCreated {get; set;}
  public BankAccount(){
    Balance = 1000;
  }
  public BankAccount(double Balance){
    this.Balance = Balance;
  }

  public void Deposit(double amount)
  {
    Balance = Balance+amount;
    Console.WriteLine("Current Balance: $"+Balance);
  }

  public virtual void Withdraw(double amount)
  {
    if(Balance > amount){
      Balance = Balance - amount;
    }
    else{
      Console.WriteLine("Insufficient Balance to Withdraw $"+amount);
    }
    Console.WriteLine("Current Balance: $"+Balance);
  }

  public abstract void CalculateInterest();
}