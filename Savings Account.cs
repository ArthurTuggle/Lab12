using System;
class SavingsAccount : BankAccount
{
  public SavingsAccount(double b) : base(b){}
  public SavingsAccount():base(){}

  public override void CalculateInterest(){
    double interest = Balance*0.05;
    Balance = Balance+interest;
  }

  public override void Withdraw(double amount){
    if(Balance < 2000){
      Console.WriteLine("Insufficient balance");
    }
    else{
      base.Withdraw(amount);
    }
  }
}