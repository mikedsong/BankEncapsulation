namespace BankEncapsulation;

public class BankAccount
{
    private double _balance;

    public void Deposit(double amount)
    {
        Console.WriteLine($"Simulating a deposit of {amount, 0:c} to you account!!");
        _balance = amount;
    }

    public double GetBalance()
    {
        return _balance;
    }

}